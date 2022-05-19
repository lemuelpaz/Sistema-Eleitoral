using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_VE_.netframe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmd_gerar_eleicoes_Click(object sender, EventArgs e)
        {
            //Iniciar Lista
            List<cl_candidatos> LISTA_CANDIDATOS = new List<cl_candidatos>()
            {
                new cl_candidatos(){nome = "Ciro Gomes", votos =0 },
                new cl_candidatos(){nome = "Jair Bolsonaro", votos =0 },
                new cl_candidatos(){nome = "Lula", votos =0 },
                new cl_candidatos(){nome = "Luciano Huck", votos =0 },


                new cl_candidatos(){nome = "BRANCOS", votos =0 },
                new cl_candidatos(){nome = "NULOS", votos =0 },
            };
            //Atribuições de votos

            Random rnd = new Random();


            for (int n = 0; n < count_votantes.Value; n++)
            {
                //Definir se é para atribuir voto branco
                if(rnd.Next(1,100) <= track_votos_brancos.Value)
                {
                    LISTA_CANDIDATOS.Where(i => i.nome == "BRANCOS").First().votos++;
                    continue;
                }

                //Definir se é para atribuir voto nulos
                if (rnd.Next(1, 100) <= track_votos_nulos.Value)
                {
                    LISTA_CANDIDATOS.Where(i => i.nome == "NULOS").First().votos++;
                    continue;
                }
                //Atribuir voto a candidato
                LISTA_CANDIDATOS[rnd.Next(0, LISTA_CANDIDATOS.Count - 2)].votos++;

            }

            lista_resultados.Items.Clear();
            var candidatos = LISTA_CANDIDATOS.Where(i => i.nome != "BRANCOS" && i.nome != "NULOS").OrderByDescending(i => i.votos);
            int posicao = 1;
            foreach(var candidato in candidatos)
            {
                lista_resultados.Items.Add(posicao.ToString() + "º " + ConstroirLinha(candidato));
                posicao++;
            }

            //Brancos e Nulos

            lista_resultados.Items.Add("");
            var outros_resultados = LISTA_CANDIDATOS.Where(i => i.nome == "BRANCOS" || i.nome == "NULOS");
            foreach (var outro_resultados in outros_resultados)
                lista_resultados.Items.Add(ConstroirLinha(outro_resultados));

            //total
            int total_volto = LISTA_CANDIDATOS.Sum(i => i.votos);
            lista_resultados.Items.Add("");
            lista_resultados.Items.Add("Total de votantes:" + total_volto);


        }

        private string ConstroirLinha(cl_candidatos item)
        {
            StringBuilder str = new StringBuilder();
            str.Append(item.nome);
            str.Append(new String('.', 30 - item.nome.Length));
            str.Append(item.votos);
            return str.ToString();
        }

    }
}
