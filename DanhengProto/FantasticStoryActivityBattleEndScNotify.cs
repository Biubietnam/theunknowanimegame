using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000501 RID: 1281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FantasticStoryActivityBattleEndScNotify : IMessage<FantasticStoryActivityBattleEndScNotify>, IMessage, IEquatable<FantasticStoryActivityBattleEndScNotify>, IDeepCloneable<FantasticStoryActivityBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x0009DF1F File Offset: 0x0009C11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FantasticStoryActivityBattleEndScNotify> Parser
		{
			get
			{
				return FantasticStoryActivityBattleEndScNotify._parser;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x0009DF26 File Offset: 0x0009C126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FantasticStoryActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x0009DF38 File Offset: 0x0009C138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FantasticStoryActivityBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0009DF3F File Offset: 0x0009C13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticStoryActivityBattleEndScNotify()
		{
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x0009DF47 File Offset: 0x0009C147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticStoryActivityBattleEndScNotify(FantasticStoryActivityBattleEndScNotify other) : this()
		{
			this.battleId_ = other.battleId_;
			this.mGGBJFFLCAE_ = other.mGGBJFFLCAE_;
			this.kLANEABKELD_ = other.kLANEABKELD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x0009DF84 File Offset: 0x0009C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FantasticStoryActivityBattleEndScNotify Clone()
		{
			return new FantasticStoryActivityBattleEndScNotify(this);
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x0009DF8C File Offset: 0x0009C18C
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x0009DF94 File Offset: 0x0009C194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x0009DF9D File Offset: 0x0009C19D
		// (set) Token: 0x0600396C RID: 14700 RVA: 0x0009DFA5 File Offset: 0x0009C1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MGGBJFFLCAE
		{
			get
			{
				return this.mGGBJFFLCAE_;
			}
			set
			{
				this.mGGBJFFLCAE_ = value;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x0009DFAE File Offset: 0x0009C1AE
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x0009DFB6 File Offset: 0x0009C1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLANEABKELD
		{
			get
			{
				return this.kLANEABKELD_;
			}
			set
			{
				this.kLANEABKELD_ = value;
			}
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0009DFBF File Offset: 0x0009C1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FantasticStoryActivityBattleEndScNotify);
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0009DFD0 File Offset: 0x0009C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FantasticStoryActivityBattleEndScNotify other)
		{
			return other != null && (other == this || (this.BattleId == other.BattleId && this.MGGBJFFLCAE == other.MGGBJFFLCAE && this.KLANEABKELD == other.KLANEABKELD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x0009E02C File Offset: 0x0009C22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleId != 0U)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.MGGBJFFLCAE != 0U)
			{
				num ^= this.MGGBJFFLCAE.GetHashCode();
			}
			if (this.KLANEABKELD != 0U)
			{
				num ^= this.KLANEABKELD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0009E09D File Offset: 0x0009C29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0009E0A5 File Offset: 0x0009C2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x0009E0B0 File Offset: 0x0009C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGGBJFFLCAE != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MGGBJFFLCAE);
			}
			if (this.KLANEABKELD != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.KLANEABKELD);
			}
			if (this.BattleId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BattleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0009E128 File Offset: 0x0009C328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleId);
			}
			if (this.MGGBJFFLCAE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MGGBJFFLCAE);
			}
			if (this.KLANEABKELD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLANEABKELD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0009E198 File Offset: 0x0009C398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FantasticStoryActivityBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleId != 0U)
			{
				this.BattleId = other.BattleId;
			}
			if (other.MGGBJFFLCAE != 0U)
			{
				this.MGGBJFFLCAE = other.MGGBJFFLCAE;
			}
			if (other.KLANEABKELD != 0U)
			{
				this.KLANEABKELD = other.KLANEABKELD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0009E1FC File Offset: 0x0009C3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0009E208 File Offset: 0x0009C408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BattleId = input.ReadUInt32();
						}
					}
					else
					{
						this.KLANEABKELD = input.ReadUInt32();
					}
				}
				else
				{
					this.MGGBJFFLCAE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040016DD RID: 5853
		private static readonly MessageParser<FantasticStoryActivityBattleEndScNotify> _parser = new MessageParser<FantasticStoryActivityBattleEndScNotify>(() => new FantasticStoryActivityBattleEndScNotify());

		// Token: 0x040016DE RID: 5854
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016DF RID: 5855
		public const int BattleIdFieldNumber = 10;

		// Token: 0x040016E0 RID: 5856
		private uint battleId_;

		// Token: 0x040016E1 RID: 5857
		public const int MGGBJFFLCAEFieldNumber = 8;

		// Token: 0x040016E2 RID: 5858
		private uint mGGBJFFLCAE_;

		// Token: 0x040016E3 RID: 5859
		public const int KLANEABKELDFieldNumber = 9;

		// Token: 0x040016E4 RID: 5860
		private uint kLANEABKELD_;
	}
}
