namespace CIS106A_W3.models {

    public class BookManagingLibrary: BookActions {
        private int nextBookId = 1;
        private Dictionary<int, Book> Library = new Dictionary<int, Book>();
        public void MainProgram() {
            /*
            - This is where the bulk of the program will take place

            - The user is first prompted for which activity they would like to perform
            - SELECT ACTION -
            - 1) Add Book
            - 2) Display Full Library
            - 3) Find Book
            - 4) Remove Book
            - 5) Exit

            - once selected, the user will be taken to the corresponding method/function
            from BookActions
            */
            
            while (true) {
                Console.WriteLine("Bookstore Options:");
                Console.WriteLine("1) Add New Book");
                Console.WriteLine("2) Remove Book");
                Console.WriteLine("3) Find Book");
                Console.WriteLine("4) Display All Books");
                Console.WriteLine("5) Exit Program");
                Console.WriteLine("Please select task (1-5) - ");
                int select = int.Parse(Console.ReadLine());

                switch(select) {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        DisplayBook();
                        break;
                    case 4:
                        DisplayBook();
                        break;
                    case 5:
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("invalid input\n");
                        break;
                }
            }
        }

        public override string AddBook() {
            Console.WriteLine("please specify the Book Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("please specify the Name of Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("please specify the Book Genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("");

            if (title == "") {
                Console.WriteLine("Input for books must not be null");
            } else if (author == "") {
                Console.WriteLine("Input for books must not be null");
            } else if (genre == "") {
                Console.WriteLine("Input for books must not be null");
            } else {
                Book newBook = new Book {
                    bookId = nextBookId,
                    bookTitle = title,
                    bookAuthor = author,
                    bookGenre = genre
                };

                Library.Add(nextBookId, newBook);

                nextBookId++;

                Console.WriteLine("Book added successfully!");
                Console.WriteLine($"Book ID: {newBook.bookId}");
                Console.WriteLine($"Book Title: {newBook.bookTitle}");
                Console.WriteLine($"Name of Author: {newBook.bookAuthor}");
                Console.WriteLine($"Book Genre: {newBook.bookGenre}\n");
            }
            
            return "You have entered ExitProgram";
        }

        public override string DisplayBook() {
            Console.WriteLine("Please specify ID (or type 'all' for entire Library) - ");
            string decide = Console.ReadLine();

            if (decide == "all") {
                foreach (var bookEntry in Library) {
                    Console.WriteLine($"Book ID: {bookEntry.Key}");
                    Console.WriteLine($"Book Title: {bookEntry.Value.bookTitle}");
                    Console.WriteLine($"Author: {bookEntry.Value.bookAuthor}");
                    Console.WriteLine($"Genre: {bookEntry.Value.bookGenre}\n");
                }
            } else {
                if (int.TryParse(decide, out int bookId)) {
                    if (Library.ContainsKey(bookId)) {
                        var book = Library[bookId];
                        Console.WriteLine($"Book ID: {bookId}");
                        Console.WriteLine($"Book Title: {book.bookTitle}");
                        Console.WriteLine($"Author: {book.bookAuthor}");
                        Console.WriteLine($"Genre: {book.bookGenre}\n");
                    } else {
                        Console.WriteLine("Book not found in the library.");
                    }
                } else {
                    Console.WriteLine("Invalid input. Please enter a valid book ID or 'all'.");
                }
            }
            return "You have entered";
        }

        public override string RemoveBook() {
            Console.WriteLine("Please select book ID- ");
            string removeID = Console.ReadLine();

            if (int.TryParse(removeID, out int bookIdToRemove)) {
                if (Library.ContainsKey(bookIdToRemove)) {
                    Library.Remove(bookIdToRemove);
                    Console.WriteLine($"Book ID {bookIdToRemove} removed successfully\n");
                } else {
                    Console.WriteLine($"No book found with ID {bookIdToRemove}\n");
                }
            } else {
                Console.WriteLine("Invalid ID format\n");
            }

            return "You have entered";
        }

        public override string ExitProgram() {
            Console.WriteLine("You have entered ExitProgram\n");
            Environment.Exit(0);
            return "You have entered ExitProgram";
        }
    }
}