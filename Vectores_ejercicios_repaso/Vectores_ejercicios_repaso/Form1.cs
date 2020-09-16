using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_ejercicios_repaso
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int[] vector = new int[50];
        int[] vector_segundo = new int[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1_Click(object sender, EventArgs e)
        {
            //Ejercicio 1
            lista_aleatoria.Items.Clear();
            for(int i=0 ; i<vector.Length ; i++)
            {
                vector[i] = aleatorio.Next(100);
                lista_aleatoria.Items.Add(vector[i]);
            }
        }

        private void lista_aleatoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ejercicio2_Click(object sender, EventArgs e)
        {
            //Ejercicio 2
            int max = -1, min = 101;
            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i] < min)
                {
                    min = vector[i];
                }
                if (vector[i] > max)
                {
                    max = vector[i];
                }
            }
            maximo_minimo.Items.Clear();
            maximo_minimo.Items.Add("Maximo: "+ max);
            maximo_minimo.Items.Add("Minimo: "+ min);
        }

        private void maximo_minimo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ejercicio3_Click(object sender, EventArgs e)
        {
            //Ejercicio 3
            posiciones20y30.Items.Clear();
            posiciones20y30.Items.Add("Posicion 20: " + vector[20]);
            posiciones20y30.Items.Add("Posicion 30: " + vector[30]);
        }

        private void posiciones20y30_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ejercicio4_Click(object sender, EventArgs e)
        {
            //Ejercicio 4
            media_aritmetica.Items.Clear();
            double media = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                media += vector[i];
            }
            media /= vector.Length;
            media_aritmetica.Items.Add("Media: " + media);
        }

        private void media_aritmetica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc5_Click(object sender, EventArgs e)
        {
            //Ejercicio 5
            menor_mayor.Items.Clear();
            Array.Sort(vector);
            for (int i = 0; i < vector.Length; i++)
            {
                menor_mayor.Items.Add(vector[i]);
            }
            
        }

        private void menor_mayor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc6_Click(object sender, EventArgs e)
        {
            //Ejercicio 6 
            num_buscado.Items.Clear();
            int num_introducido = Convert.ToInt32(num_escrito.Text);
            int cantidad = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == num_introducido)
                {
                    cantidad++;
                }
            }
            num_buscado.Items.Add("Cantidad: " + cantidad);

        }

        private void num_escrito_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_buscado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc7_Click(object sender, EventArgs e)
        {
            //Ejercicio 7
            invertir.Items.Clear();
            Array.Reverse(vector);
            for (int i = 0; i < vector.Length; i++)
            {
                invertir.Items.Add(vector[i]);
            }
        }

        private void invertir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc8_Click(object sender, EventArgs e)
        {
            //Ejercicio 8
            repetidos.Items.Clear();
            int num = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == num)
                {
                    vector[i] = -1;
                }
                else
                {
                    num = vector[i];
                }
                    
                
                repetidos.Items.Add(vector[i]);
            }
        }

        private void repetidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc9_Click(object sender, EventArgs e)
        {
            //Ejercicio 9
            nuevo_vector.Items.Clear();

            for (int i = 0; i < vector_segundo.Length; i++)
            {
                Boolean continuar = true;
                while(continuar)
                {
                    int numero = aleatorio.Next(100);
                    Boolean esta = false;
                    for(int j = 0 ; j < i ; j++)
                    {
                        if (numero == vector_segundo[j])
                        {
                            esta = true;
                        }
                    }
                    if(esta == false)
                        continuar =false;
                    vector_segundo[i] = numero;
                }
                nuevo_vector.Items.Add(vector_segundo[i]);
            }

        }

        private void nuevo_vector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc10_Click(object sender, EventArgs e)
        {
            //Ejercicio 10 
            inferiores_y_superiores.Items.Clear();
            int inferiores = 0 , mayores = 0;
            for (int i = 0; i < vector_segundo.Length; i++)
            {
                if (vector_segundo[i] < 25)
                {
                    inferiores++;
                }
                if (vector_segundo[i] > 25)
                {
                    mayores++;
                }
            }
            inferiores_y_superiores.Items.Add("Inferiores de 25: " + inferiores);
            inferiores_y_superiores.Items.Add("Mayores de 25: " + mayores);
        }

        private void inferiores_y_superiores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc11_Click(object sender, EventArgs e)
        {
            //Ejercicio 11
            ordenar_vector.Items.Clear();
            Array.Sort(vector_segundo);
            Array.Reverse(vector_segundo);
            for (int i = 0; i < vector_segundo.Length; i++)
            {
                ordenar_vector.Items.Add(vector_segundo[i]);
            }

        }

        private void ordenar_vector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc12_Click(object sender, EventArgs e)
        {
            //Ejercicio 12
            numero_mostrado.Items.Clear();
            int num_intro = Convert.ToInt16(num_introducido.Text);
            for (int i = 0; i < vector_segundo.Length; i++)
            {
                if(vector_segundo[i] == num_intro)
                {
                    int numero = aleatorio.Next(100);
                    for (int z = 0; z < vector_segundo.Length; z++)
                    {
                        Boolean continuar = true;
                        while (continuar)
                        {
                            numero = aleatorio.Next(100);
                            Boolean esta = false;
                            for (int j = 0; j < i; j++)
                            {
                                if (numero == vector_segundo[j])
                                {
                                    esta = true;
                                }
                            }
                            if (esta == false)
                                continuar = false;
                            vector_segundo[i] = numero;
                        }
                    }
                }
                numero_mostrado.Items.Add(vector_segundo[i]);
            }

        }

        private void num_introducido_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_mostrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ejerc13_Click(object sender, EventArgs e)
        {
            //Ejercicio 13
            superiores_inferiores_13.Items.Clear();
            int num_intro = Convert.ToInt16(num_introducido_13.Text);

            int inferiores = 0, mayores = 0;

            for (int i = 0; i < vector_segundo.Length; i++)
            {
                if (vector_segundo[i] < num_intro)
                {
                    inferiores++;
                }
                if (vector_segundo[i] > num_intro)
                {
                    mayores++;
                }
            }
            superiores_inferiores_13.Items.Add("Inferiores de "+ num_intro + ": " + inferiores);
            superiores_inferiores_13.Items.Add("Mayores de " + num_intro + ": " + mayores);
        }

        private void num_introducido_13_TextChanged(object sender, EventArgs e)
        {

        }

        private void superiores_inferiores_13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
