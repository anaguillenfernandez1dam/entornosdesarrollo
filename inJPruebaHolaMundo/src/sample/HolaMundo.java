package sample;

import javafx.event.ActionEvent;
import javafx.scene.control.Label;

public class HolaMundo {
    public Label helloWorld;

    public void sayHelloWorld(ActionEvent actionEvent){
        helloWorld.setText("Hola Mundo");
    }
}
