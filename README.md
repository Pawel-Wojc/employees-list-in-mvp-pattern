"# employees-list-in-mvp-pattern" 
TO-DO: move db setting to another file

The model is an interface defining the data to be displayed or otherwise acted upon in the user interface.
The view is a passive interface that displays data (the model) and routes user commands (events) to the presenter to act upon that data.
The presenter acts upon the model and the view. It retrieves data from repositories (the model), and formats it for display in the view.
![](img.png?raw=true)
