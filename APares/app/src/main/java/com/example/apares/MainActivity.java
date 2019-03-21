package com.example.apares;

import android.os.Handler;
import android.support.constraint.ConstraintLayout;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
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
    private Button boton1, boton2;
    private TextView texto;
    private ConstraintLayout layout2;
    private boolean flag;
    List<Button> buttons;
    private int aciertos;

    private Handler handler = new Handler();


    private void initPalabras(){
        palabras.addAll(Arrays.asList(frase.split(" ")));
        Collections.shuffle(palabras);
    }

    private void initButtons(){

        buttons = getLeafButtons(layout2);

        for (int i = 0; i < buttons.size(); i++){
            buttons.get(i).setText(palabras.get(i));
        }

        handler.postDelayed( new Runnable(){
            @Override
            public void run(){
                for (int i = 0; i < buttons.size(); i++){
                    buttons.get(i).setText("");
                    buttons.get(i).setTag(palabras.get(i));
                }
            }
        }, 2000);

    }

    private List<Button> getLeafButtons(ViewGroup viewGroup){
        List<Button> leafChildren = new ArrayList<>();

        for (int i= 0; i < viewGroup.getChildCount(); i++){
            Button boton = (Button) viewGroup.getChildAt(i);
            leafChildren.add(boton);
        }

        return leafChildren;
    }

    public void tarjetaOnClick(View view){

        if (view.getTag() != ""){
            //Button boton = (Button) findViewById(view.getId());
            if (!flag){
                boton1 = (Button) view;
                texto1 = (String) boton1.getTag();
                boton1.setText((String)boton1.getTag());
                flag = true;

            }else{
                boton2 = (Button) view;
                texto2 = (String) boton2.getTag();
                boton2.setText((String)boton2.getTag());

                flag = false;

                if (texto1.equals(texto2)) {
                    aciertos++;
                    texto.setText("Aciertos: " + aciertos);
                    texto1 = null;
                    texto2 = null;
                    boton1.setTag("");
                    boton2.setTag("");
                }else{
                    handler.postDelayed(new Runnable(){
                        @Override
                        public void run(){
                            boton1.setText("");
                            boton2.setText("");
                        }
                    }, 1000);
                }
            }//Fin comprobar flag
        }//Fin comprobar tag


        if (aciertos >= 6){
            texto.setText("¡Felicidades, has ganado!");
        }

    }//fin tarjetaOnClick

    public void reiniciar(View view){
        aciertos = 0;
        texto.setText("Aciertos: " + aciertos);
        Collections.shuffle(palabras);
        initButtons();
    }



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        texto = findViewById(R.id.textoIntentos);
        layout2 = findViewById(R.id.ConstraintLayout2);
        initPalabras();
        initButtons();

        aciertos = 0;
        flag = false;

        texto.setText("Aciertos: " + aciertos);

    }


}
