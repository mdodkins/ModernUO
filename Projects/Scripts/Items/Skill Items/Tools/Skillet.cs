using Server.Engines.Craft;

namespace Server.Items
{
  public class Skillet : BaseTool
  {
    [Constructible]
    public Skillet() : base(0x97F) => Weight = 1.0;

    [Constructible]
    public Skillet(int uses) : base(uses, 0x97F) => Weight = 1.0;

    public Skillet(Serial serial) : base(serial)
    {
    }

    public override int LabelNumber => 1044567; // skillet

    public override CraftSystem CraftSystem => DefCooking.CraftSystem;

    public override void Serialize(IGenericWriter writer)
    {
      base.Serialize(writer);

      writer.Write(0); // version
    }

    public override void Deserialize(IGenericReader reader)
    {
      base.Deserialize(reader);

      int version = reader.ReadInt();
    }
  }
}