﻿using crud_rpg.src.model;
namespace crud_rpg.src.repository.Interface
{
	public interface IItemMagicoRepository
	{
		public void AdicionarItemMagico(ItemMagico itemMagico);
        public List<ItemMagico> ListarItensMagicos();
		public ItemMagico ListaItemMagico(long id);
		public void AdicionarItemMagicoAoPersonagem(long id, long idItemMagico);
		public List<ItemMagico> ListarItemMagicoPorPersonagem(long id, long idItemMagico);
		public void RemoverItemMagicoDoPeronagem(long id, long idItemMagico);
    }
}

