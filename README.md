# Four principals of OOP
- **Encapsulation**: The `MemberService` class hides the details of its implementation and only exposes public methods for interaction. This is evident in the usage of the `private readonly BookService _bookService` and `private Member Member` properties.

- **Inheritance**: The `VIPMember` and `NormalMember` classes both inherit from the `Member` class. This is shown in the switch case where depending on the `Member.Type`, a new instance of either `VIPMember` or `NormalMember` is created.

- **Abstraction**: The `MemberService` class doesn't need to know how the `BookService` class implements its methods. It only needs to know that it can call these methods and expect certain results. This is shown in the `BorrowBook` and `ReturnBook` methods where `_bookService.Borrow(bookCode)` and `_bookService.Return(bookCode)` are called respectively.

- **Polymorphism**: Dfferent member types have different limitations on the number of books they can borrow. This is demonstrated in the `BorrowBook` and `ReturnBook` methods where `Member.Limit()` is called. Depending on whether `Member` is an instance of `VIPMember` or `NormalMember`, a different implementation of the `Limit` method will be used.