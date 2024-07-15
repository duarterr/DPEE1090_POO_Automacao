namespace Course
{
    // Definição da interface IItemEmprestavel dentro do namespace Course
    public interface IItemEmprestavel
    {
        // Método Emprestar que recebe um parâmetro do tipo Usuario
        void Emprestar(Usuario usuario);

        // Método Devolver que não recebe parâmetros
        void Devolver();
    }
}
