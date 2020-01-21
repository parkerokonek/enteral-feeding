#include "mainwindow.hpp"

int main(int argc, char **argv) {
    QApplication app(argc, argv);
    Ui_MainWindow ui = Ui_MainWindow();
    QMainWindow window = QMainWindow();
    
    ui.setupUi(&window);

    window.show();
    
    return app.exec();
}