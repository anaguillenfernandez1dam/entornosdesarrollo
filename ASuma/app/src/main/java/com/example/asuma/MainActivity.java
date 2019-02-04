package com.example.asuma;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void sumar(View view){

        EditText num1 = findViewById(R.id.num1);
        EditText num2 = findViewById(R.id.num2);

        int resultado = Integer.parseInt(num1.getText().toString()) + Integer.parseInt(num2.getText().toString());

        TextView textoResult = findViewById(R.id.resultado);
        textoResult.setText("Resultado: " + Integer.toString(resultado));

    }


}
