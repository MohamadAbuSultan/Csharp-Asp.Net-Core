# Implementing a web API in .NET

### **تنفيذ Web API باستخدام .NET**

في هذا الشرح، سنتعرف على كيفية إنشاء **Web API** باستخدام **ASP.NET Core** بالاعتماد على **Minimal APIs**، وسنقوم ببناء API يدعم عمليات **CRUD** (إنشاء، قراءة، تحديث، وحذف) لقائمة مهام (To-Do List).  

---

## **1. مقدمة حول Web APIs و ASP.NET Core**
تتبع **Web APIs** نموذج **طلب-استجابة (Request-Response Pattern)**، حيث يقوم **العميل (Client)** بإرسال **طلب (Request)** إلى **الخادم (Server)**، والخادم مسؤول عن معالجة هذا الطلب وإرجاع **استجابة (Response)** مناسبة.  

يتيح لنا **ASP.NET Core Minimal APIs** تحديد كيفية معالجة الطلبات باستخدام كائن يُعرف باسم **Endpoint**، مما يسهل علينا إنشاء **Web API** بشكل مبسط وسريع.

---

## **2. تعريف Endpoints باستخدام Minimal APIs**
تُستخدم Minimal APIs لتحديد النقاط النهائية (Endpoints) التي تعالج الطلبات الواردة. على سبيل المثال، إذا أردنا التعامل مع طلب **GET**، يمكننا استخدام `MapGet()` لتحديد كيفية معالجة هذا الطلب.

### **مثال على تنفيذ طلب GET**
```csharp
var app = WebApplication.CreateBuilder(args).Build();

app.MapGet("/", () => "Hello, World!");

app.Run();
```
- **`MapGet("/", () => "Hello, World!");`**  
  - `GET`: هو **HTTP Method** يشير إلى أن العميل يطلب معلومات من الخادم.  
  - `"/"`: هو **المسار (Route)** الذي سيتم معالجة الطلب عليه.  
  - `() => "Hello, World!"`: هو **معالج الطلب (Request Handler)** الذي يتم تنفيذه عند وصول الطلب.  

بعد تشغيل التطبيق، يمكننا إرسال طلب **GET** إلى `http://localhost:5144/` عبر المتصفح أو باستخدام ملف **HTTP Request** داخل VS Code.

---

## **3. إرسال طلب HTTP باستخدام ملف MyRequests.http**
بدلًا من استخدام المتصفح لاختبار **API**، يمكننا إرسال الطلبات مباشرةً من داخل **VS Code** باستخدام ملف `.http` كما يلي:

```http
GET http://localhost:5144/
```
عند إرسال الطلب، سنحصل على استجابة تحتوي على النص:  
```json
"Hello, World!"
```

---

## **4. إنشاء Web API يدعم عمليات CRUD**
### **4.1 تعريف كائن To-Do**
نحتاج إلى تعريف نوع بيانات يمثل المهام التي سيتم التعامل معها داخل التطبيق، ويمكننا استخدام **Records** لتعريف كائن `Todo` كما يلي:

```csharp
record Todo(int Id, string Name, DateTime DueDate, bool IsCompleted);
```
- `Id`: رقم تعريفي لكل مهمة.
- `Name`: اسم المهمة.
- `DueDate`: تاريخ الاستحقاق.
- `IsCompleted`: حالة إنجاز المهمة.

### **4.2 إنشاء قائمة تخزين المهام**
بما أننا لا نستخدم قاعدة بيانات في هذا المثال، سنخزن المهام داخل **List في الذاكرة**:

```csharp
var todos = new List<Todo>();
```
⚠ **ملاحظة:** بما أن المهام تُخزن في الذاكرة، فسيتم حذف جميع البيانات بمجرد إيقاف التطبيق. في التطبيقات الحقيقية، يتم استخدام قاعدة بيانات لتخزين هذه البيانات.

---

## **5. تنفيذ العمليات الأساسية (CRUD)**
### **5.1 إضافة مهمة جديدة (Create - POST)**
لإضافة مهمة جديدة إلى القائمة، نستخدم `MapPost()`:

```csharp
app.MapPost("/todos", (Todo todo) => {
    todos.Add(todo);
    return Results.Created($"/todos/{todo.Id}", todo);
});
```
- `MapPost("/todos", (Todo todo) => {...});`  
  - يُحدد أن الطلبات من نوع **POST** على المسار `/todos` سيتم معالجتها بهذه الطريقة.
- **إضافة المهمة إلى القائمة**: `todos.Add(todo);`
- **إرجاع استجابة 201 Created**: تُستخدم للإشارة إلى أن المورد قد تم إنشاؤه بنجاح.

---

### **5.2 استرجاع مهمة محددة (Read - GET)**
لاسترجاع مهمة معينة باستخدام **معرّف (ID)**، نستخدم `MapGet()` مع **Route Parameters**:

```csharp
app.MapGet("/todos/{id}", (int id) => {
    var todo = todos.FirstOrDefault(t => t.Id == id);
    return todo is not null ? Results.Ok(todo) : Results.NotFound();
});
```
- `{id}`: يُستخدم كـ **Parameter** لاستخراج قيمة المعرّف من عنوان الطلب.
- `todos.FirstOrDefault(t => t.Id == id)`: يبحث عن المهمة في القائمة.
- `Results.Ok(todo)`: يُرجع **200 OK** في حالة العثور على المهمة.
- `Results.NotFound()`: يُرجع **404 Not Found** إذا لم يتم العثور على المهمة.

---

### **5.3 تحديث مهمة موجودة (Update - PUT)**
لتحديث بيانات مهمة محددة، نستخدم `MapPut()`:

```csharp
app.MapPut("/todos/{id}", (int id, Todo updatedTodo) => {
    var index = todos.FindIndex(t => t.Id == id);
    if (index == -1) return Results.NotFound();

    todos[index] = updatedTodo;
    return Results.Ok(updatedTodo);
});
```
- `FindIndex(t => t.Id == id)`: البحث عن المهمة في القائمة باستخدام **ID**.
- `todos[index] = updatedTodo;`: تحديث بيانات المهمة.
- **إرجاع استجابة `200 OK`** عند نجاح التحديث.

---

### **5.4 حذف مهمة (Delete - DELETE)**
لحذف مهمة من القائمة، نستخدم `MapDelete()`:

```csharp
app.MapDelete("/todos/{id}", (int id) => {
    var todo = todos.FirstOrDefault(t => t.Id == id);
    if (todo is null) return Results.NotFound();

    todos.Remove(todo);
    return Results.Ok(todo);
});
```
- **البحث عن المهمة**: `todos.FirstOrDefault(t => t.Id == id);`
- **حذف المهمة**: `todos.Remove(todo);`
- **إرجاع 200 OK** في حالة النجاح، أو **404 Not Found** إذا لم يتم العثور على المهمة.

---

## **6. تشغيل التطبيق واختباره**
لتشغيل التطبيق، نقوم بتشغيل الأمر التالي في **VS Code**:

```
dotnet run
```
يبدأ التطبيق في العمل، ويمكننا اختبار API باستخدام المتصفح أو باستخدام ملف `MyRequests.http`.

### **مثال على إرسال طلب GET لاسترجاع جميع المهام:**
```http
GET http://localhost:5144/todos
```
### **مثال على إرسال طلب POST لإضافة مهمة جديدة:**
```http
POST http://localhost:5144/todos
Content-Type: application/json

{
  "id": 1,
  "name": "إتمام مشروع ASP.NET",
  "dueDate": "2024-02-29T00:00:00",
  "isCompleted": false
}
```

---

## **7. الخلاصة**
- تعلمنا كيفية إنشاء **Web API** باستخدام **ASP.NET Core Minimal APIs**.
- نفذنا العمليات الأساسية **CRUD** (إنشاء، قراءة، تحديث، حذف).
- استخدمنا **HTTP Methods** مثل **GET, POST, PUT, DELETE** للتفاعل مع البيانات.
- اختبرنا التطبيق باستخدام **VS Code** وملفات **.http**.