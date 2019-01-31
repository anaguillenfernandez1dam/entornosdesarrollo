package com.example.myfirstapp;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    public static final String KEY_MESSAGE = "clave1";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void sendMessage(View view){
        EditText editText = findViewById(R.id.editText);
        System.out.println("ejecutando sendMessage " + editText.getText().toString());
        String message = editText.getText().toString();

        Intent intent = new Intent(this, DisplayMessageActivity.class);
        intent.putExtra(MainActivity.KEY_MESSAGE, message);
        startActivity(intent);
    }


    public static String getMessage(){
        return message;
    }
}
