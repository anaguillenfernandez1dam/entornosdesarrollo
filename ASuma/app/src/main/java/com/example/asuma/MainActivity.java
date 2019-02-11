package com.example.asuma;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.math.BigDecimal;

public class MainActivity extends AppCompatActivity {

    private EditText num1;
    private EditText num2;
    private TextView textoResult;
    private BigDecimal resultado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        num1 = findViewById(R.id.num1);
        num2 = findViewById(R.id.num2);
        textoResult = findViewById(R.id.resultado);
    }

    private BigDecimal getNum1(){
        String string1 = num1.getText().toString();
        return new BigDecimal(string1);
    }

    private BigDecimal getNum2(){
        String string2 = num2.getText().toString();
        return new BigDecimal(string2);
    }

    public void sumar(View view){

        resultado = getNum1().add(getNum2());
        textoResult.setText("Resultado: " + String.valueOf(resultado));

    }

    public void restar(View view){

        resultado = getNum1().subtract(getNum2());
        textoResult.setText("Resultado: " + String.valueOf(resultado));



    }


}
