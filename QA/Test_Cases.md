# Test Cases – Library Management System

| TC ID | Feature             | Test Scenario                            | Steps                                                                 | Expected Result                          | Status |
|-------|---------------------|------------------------------------------|-----------------------------------------------------------------------|-------------------------------------------|--------|
| TC01  | Member Registration | Valid registration                       | Enter name, email, ID and submit                                      | Member is saved successfully              |  Pass |
| TC02  | Member Registration | Missing required fields                  | Leave email blank and click register                                 | Show error: "Email is required"           | Pass |
| TC03  | Book Borrowing      | Borrow available book                    | Select book and member, click borrow                                 | Book status changes to "Borrowed"         | Pass |
| TC04  | Book Borrowing      | Borrow already borrowed book             | Try to borrow a book that is not available                           | Show error: "Book already borrowed"       | Pass |
| TC05  | Fine Calculation    | Late return                              | Return book 5 days late                                               | Fine calculated correctly (e.g., Rs.50)   | Pass |
| TC06  | Return Deadline     | Return before due date                   | Return book 2 days early                                              | No fine                                   | Pass |
