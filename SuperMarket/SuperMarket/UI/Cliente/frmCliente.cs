using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UI.Cliente
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        Business.ClienteBusiness business = new Business.ClienteBusiness();
        Models.tb_cliente clienteModel = new Models.tb_cliente();
        Models.tb_enederecocliente endModel = new Models.tb_enederecocliente();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            clienteModel = new Models.tb_cliente();

            clienteModel.ds_cpf_cnpj = txtCpf.Text;
            clienteModel.ds_idade = Convert.ToInt32(txtIdade.Text);
            clienteModel.ds_sexo = cboSexo.Text;
            clienteModel.ds_tipo_pessoa = cboTipoPessoa.Text;
            clienteModel.dt_cadastro = DateTime.Now;
            clienteModel.nm_cliente = txtCliente.Text;

            business.Insert(clienteModel);

            endModel = new Models.tb_enederecocliente();
            endModel.ds_cep = txtCep.Text;
            endModel.ds_numero = Convert.ToInt32(txtNumero.Text);
            endModel.nm_bairro = txtBairro.Text;
            endModel.nm_cidade = txtCidade.Text;
            endModel.nm_endereco = txtEndereco.Text;
            endModel.nm_estado = cboEstado.Text;
            endModel.tb_cliente_idtb_cliente = clienteModel.idtb_cliente;

            business.InsertEndereco(endModel);

            DialogResult d = MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
