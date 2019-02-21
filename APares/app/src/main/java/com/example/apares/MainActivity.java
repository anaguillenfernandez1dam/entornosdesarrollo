package com.example.apares;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    List<String> palabras = new ArrayList<>();
    private String frase = "Lobo Rana Oveja Gato Pato Llama Lobo Rana Oveja Gato Pato Llama";
    private String texto1, texto2;

    private TextView texto;

    private boolean flag;

    List<Button> buttons = new ArrayList<>();

    private int aciertos;

    private void initPalabras(){
        palabras.addAll(Arrays.asList(frase.split(" ")));
        Collections.shuffle(palabras);
    }

    private void initButtons(){

        buttons.add((Button) findViewById(R.id.t1));
        buttons.add((Button) findViewById(R.id.t2));
        buttons.add((Button) findViewById(R.id.t3));
        buttons.add((Button) findViewById(R.id.t4));
        buttons.add((Button) findViewById(R.id.t5));
        buttons.add((Button) findViewById(R.id.t6));
        buttons.add((Button) findViewById(R.id.t7));
        buttons.add((Button) findViewById(R.id.t8));
        buttons.add((Button) findViewById(R.id.t9));
        buttons.add((Button) findViewById(R.id.t10));
        buttons.add((Button) findViewById(R.id.t11));
        buttons.add((Button) findViewById(R.id.t12));

        for (int i = 0; i < buttons.size(); i++){
            buttons.get(i).setText(palabras.get(i));
        }
    }

    public void tarjetaOnClick(View view){

        //Button boton = (Button) findViewById(view.getId());
        Button boton = (Button)view;
        int index = buttons.indexOf(boton);

        if (!flag){
            texto1 = (String) boton.getText();
            flag = true;
        }else{
            texto2 = (String) boton.getText();
            flag = false;

            if (texto1.equals(texto2)){
                aciertos++;
                texto.setText("Aciertos: " + aciertos);
                texto1 = null;
                texto2 = null;
            }
        }

        if (aciertos >= 6){
            texto.setText("¡Felicidades, has ganado!");
        }


    }



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        texto = findViewById(R.id.textoIntentos);
        initPalabras();
        initButtons();

        aciertos = 0;
        flag = false;


        texto.setText("Aciertos: " + aciertos);

    }


}
