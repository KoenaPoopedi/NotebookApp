# Notebook Console Application

Welcome to the Notebook Console Application! This is a simple command-line tool
for managing your notes with different types of pages. 
This README will guide you through the basic functionality and commands of the application.

# Overview

The Notebook Console Application is a text-based tool that allows you to create, display,
and manage different types of pages within your notebook. The types of pages you can work with include:

- **Image Page**: For storing and referencing images.
- **Message Page**: For writing and storing text notes.
- **List Page**: For creating and managing lists.

# Commands

Here is a list of commands you can use to interact with the application:

### 1. `new <keyword>`

- **Description**: Creates a new page in your notebook.
- **Usage**:
  - `new image` - Create a new image page.
  - `new message` - Create a new message page.
  - `new list` - Create a new list page.

### 2. `show <page_id>`

- **Description**: Displays the content of the specified page.
- **Usage**:
  - `show <page_id>` - Replace `<page_id>` with the identifier of the page you want to view.

### 3. `delete <page_id>`

- **Description**: Erases the specified page from your notebook.
- **Usage**:
  - `delete <page_id>` - Replace `<page_id>` with the identifier of the page you want to delete.

### 4. `logger <on|off>`

- **Description**: Toggles logging of the program's activity.
- **Usage**:
  - `logger on` - Turn on logging to track program activities.
  - `logger off` - Turn off logging.

## How to Use

1. **Starting the Application**: Run the application from your command line interface.
2. **Creating a Page**: Use the `new` command with the appropriate keyword to create a new page.
3. **Viewing a Page**: Use the `show` command followed by the page ID to view its content.
4. **Deleting a Page**: Use the `delete` command followed by the page ID to remove a page.
5. **Logging**: Use the `logger` command to turn logging on or off for tracking the application’s activity.

## Example Usage

- To create a new message page: `new message`
- To view a page with ID `1`: `show 1`
- To delete a page with ID `2`: `delete 2`
- To enable logging: `logger on`

## Contributing

If you have suggestions or improvements for the Notebook Console Application,
feel free to contribute by submitting an issue or a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, please contact [koenapoopedi4.0@gmail.com]. 
---

Happy note-taking!
