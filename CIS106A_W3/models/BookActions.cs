namespace CIS106A_W3.models {

    public class BookActions {
        
        public virtual string AddBook() {
            /*
            - take in the three string user inputs as parameters
            - take those 3 inputs and created a new instance of Book
            - this new instance can then be given a unique ID and be
              put into a Dictionary
            */
            return "Added Book";
        }

        public virtual string DisplayBook() {
            /*
            - takes in users int input as parameters
            - uses this int input to locate an entry in the dictionary
            - Displays all contents of said entry
            - 
            - If no parameters are specified, display every entry in Dictionary
              by default
            */
            return "Displaying Book";
        }

        public virtual string RemoveBook() {
            /*
            - takes in users int input as parameters
            - uses this int input to locate an entry in the dictionary
            - this entry is then deleted from the dictionary
            */
            return "Removed Book";
        }

        public virtual string ExitProgram() {
            /*
            - this method does not take parameters
            - when activated, it will delete all book objects, then exit.
            */
            return "Exiting program";
        }
    }
}