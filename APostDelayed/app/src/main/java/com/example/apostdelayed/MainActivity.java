package com.example.apostdelayed;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    private Button button;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void onButtonClick(View view){
        String msg = "Ejecutando onButtonClick";
        Log.i(MainActivity.class.getSimpleName(), msg);
        button = (Button) view;
        button.setText("Hola holita");

        button.postDelayed(
                new Runnable(){

                @Override
                public void run(){
                        button.setText("");
                    }
                }
                , 2000);
    }
}
