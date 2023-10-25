using WorkingWithBD;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking; // CollectionEntry

using (Almacen db = new())
{

    var Diego = db.Estudiantes
    .Include(p => p.Grupo).Where(i => i.EstudianteId == 20300697).Include(p => p.Semestre).Where(i => i.EstudianteId == 20300697);

    foreach(Estudiante e in Diego)
    {

        WriteLine($"El Id {e.EstudianteId} es de {e.Nombre} en el semestre {e.Semestre.Numero} en el grupo {e.Grupo.Nombre}");

    }
    
}
