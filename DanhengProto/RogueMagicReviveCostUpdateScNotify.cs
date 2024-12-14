using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EFB RID: 3835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicReviveCostUpdateScNotify : IMessage<RogueMagicReviveCostUpdateScNotify>, IMessage, IEquatable<RogueMagicReviveCostUpdateScNotify>, IDeepCloneable<RogueMagicReviveCostUpdateScNotify>, IBufferMessage
	{
		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600AB49 RID: 43849 RVA: 0x001CD66F File Offset: 0x001CB86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicReviveCostUpdateScNotify> Parser
		{
			get
			{
				return RogueMagicReviveCostUpdateScNotify._parser;
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x001CD676 File Offset: 0x001CB876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicReviveCostUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x001CD688 File Offset: 0x001CB888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicReviveCostUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x001CD68F File Offset: 0x001CB88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveCostUpdateScNotify()
		{
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x001CD697 File Offset: 0x001CB897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveCostUpdateScNotify(RogueMagicReviveCostUpdateScNotify other) : this()
		{
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x001CD6CC File Offset: 0x001CB8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveCostUpdateScNotify Clone()
		{
			return new RogueMagicReviveCostUpdateScNotify(this);
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0600AB4F RID: 43855 RVA: 0x001CD6D4 File Offset: 0x001CB8D4
		// (set) Token: 0x0600AB50 RID: 43856 RVA: 0x001CD6DC File Offset: 0x001CB8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RogueReviveCost
		{
			get
			{
				return this.rogueReviveCost_;
			}
			set
			{
				this.rogueReviveCost_ = value;
			}
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x001CD6E5 File Offset: 0x001CB8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicReviveCostUpdateScNotify);
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x001CD6F3 File Offset: 0x001CB8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicReviveCostUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueReviveCost, other.RogueReviveCost) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x001CD728 File Offset: 0x001CB928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueReviveCost_ != null)
			{
				num ^= this.RogueReviveCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x001CD764 File Offset: 0x001CB964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x001CD76C File Offset: 0x001CB96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x001CD775 File Offset: 0x001CB975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x001CD7A8 File Offset: 0x001CB9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueReviveCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x001CD7E8 File Offset: 0x001CB9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicReviveCostUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueReviveCost_ != null)
			{
				if (this.rogueReviveCost_ == null)
				{
					this.RogueReviveCost = new ItemCostData();
				}
				this.RogueReviveCost.MergeFrom(other.RogueReviveCost);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x001CD83C File Offset: 0x001CBA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x001CD848 File Offset: 0x001CBA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueReviveCost_ == null)
					{
						this.RogueReviveCost = new ItemCostData();
					}
					input.ReadMessage(this.RogueReviveCost);
				}
			}
		}

		// Token: 0x040045E7 RID: 17895
		private static readonly MessageParser<RogueMagicReviveCostUpdateScNotify> _parser = new MessageParser<RogueMagicReviveCostUpdateScNotify>(() => new RogueMagicReviveCostUpdateScNotify());

		// Token: 0x040045E8 RID: 17896
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045E9 RID: 17897
		public const int RogueReviveCostFieldNumber = 4;

		// Token: 0x040045EA RID: 17898
		private ItemCostData rogueReviveCost_;
	}
}
