package sample;

import javafx.fxml.FXML;

import java.awt.*;
import java.awt.event.ActionEvent;

public class Controller {

    @FXML private Label labelSaludo;
    @FXML private TextField textField;


    @FXML public void onButtonAction(ActionEvent actionEvent){
        System.out.println("Has hecho click");
        String nombre = textField.getText();
        labelSaludo.setText("Hola " + nombre);
    }


}
