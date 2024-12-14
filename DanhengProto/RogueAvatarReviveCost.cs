using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E0D RID: 3597
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAvatarReviveCost : IMessage<RogueAvatarReviveCost>, IMessage, IEquatable<RogueAvatarReviveCost>, IDeepCloneable<RogueAvatarReviveCost>, IBufferMessage
	{
		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600A0C5 RID: 41157 RVA: 0x001AF5F5 File Offset: 0x001AD7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAvatarReviveCost> Parser
		{
			get
			{
				return RogueAvatarReviveCost._parser;
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0600A0C6 RID: 41158 RVA: 0x001AF5FC File Offset: 0x001AD7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAvatarReviveCostReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600A0C7 RID: 41159 RVA: 0x001AF60E File Offset: 0x001AD80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAvatarReviveCost.Descriptor;
			}
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x001AF615 File Offset: 0x001AD815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAvatarReviveCost()
		{
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x001AF61D File Offset: 0x001AD81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAvatarReviveCost(RogueAvatarReviveCost other) : this()
		{
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x001AF652 File Offset: 0x001AD852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAvatarReviveCost Clone()
		{
			return new RogueAvatarReviveCost(this);
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x001AF65A File Offset: 0x001AD85A
		// (set) Token: 0x0600A0CC RID: 41164 RVA: 0x001AF662 File Offset: 0x001AD862
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

		// Token: 0x0600A0CD RID: 41165 RVA: 0x001AF66B File Offset: 0x001AD86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAvatarReviveCost);
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x001AF679 File Offset: 0x001AD879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAvatarReviveCost other)
		{
			return other != null && (other == this || (object.Equals(this.RogueReviveCost, other.RogueReviveCost) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x001AF6AC File Offset: 0x001AD8AC
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

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x001AF6E8 File Offset: 0x001AD8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x001AF6F0 File Offset: 0x001AD8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x001AF6F9 File Offset: 0x001AD8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x001AF72C File Offset: 0x001AD92C
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

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x001AF76C File Offset: 0x001AD96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAvatarReviveCost other)
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

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x001AF7C0 File Offset: 0x001AD9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x001AF7CC File Offset: 0x001AD9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
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

		// Token: 0x040041DE RID: 16862
		private static readonly MessageParser<RogueAvatarReviveCost> _parser = new MessageParser<RogueAvatarReviveCost>(() => new RogueAvatarReviveCost());

		// Token: 0x040041DF RID: 16863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E0 RID: 16864
		public const int RogueReviveCostFieldNumber = 5;

		// Token: 0x040041E1 RID: 16865
		private ItemCostData rogueReviveCost_;
	}
}
