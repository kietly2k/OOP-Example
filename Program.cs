using Library.Services;

Console.Write("Please enter your email: ");
string email = Console.ReadLine() + "";

Console.Write("What do you want: \n 1.Borrow book \n 2.Return book \n");
string choose = Console.ReadLine();

Console.Write($"Please enter the book code you wanna {(choose == "1" ? "borrow" : "return")}: ");
string code = Console.ReadLine() + "";

MemberService memberService = new(email);

int limit = 0;
if (choose == "1")
    limit = memberService.BorrowBook(code);
else if (choose == "2")
    limit = memberService.ReturnBook(code);

Console.WriteLine($"{(choose == "1" ? "Borrow" : "Return")} book success. You can now borrow {limit} more books. Enjoy exploring our collection!");
