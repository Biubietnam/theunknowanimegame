using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200005F RID: 95
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideSkillItemScNotify : IMessage<AetherDivideSkillItemScNotify>, IMessage, IEquatable<AetherDivideSkillItemScNotify>, IDeepCloneable<AetherDivideSkillItemScNotify>, IBufferMessage
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000BDF5 File Offset: 0x00009FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideSkillItemScNotify> Parser
		{
			get
			{
				return AetherDivideSkillItemScNotify._parser;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000BDFC File Offset: 0x00009FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideSkillItemScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000BE0E File Offset: 0x0000A00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideSkillItemScNotify.Descriptor;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000BE15 File Offset: 0x0000A015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSkillItemScNotify()
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000BE1D File Offset: 0x0000A01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSkillItemScNotify(AetherDivideSkillItemScNotify other) : this()
		{
			this.num_ = other.num_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000BE4E File Offset: 0x0000A04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSkillItemScNotify Clone()
		{
			return new AetherDivideSkillItemScNotify(this);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000BE56 File Offset: 0x0000A056
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0000BE5E File Offset: 0x0000A05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000BE67 File Offset: 0x0000A067
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0000BE6F File Offset: 0x0000A06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000BE78 File Offset: 0x0000A078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideSkillItemScNotify);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000BE86 File Offset: 0x0000A086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideSkillItemScNotify other)
		{
			return other != null && (other == this || (this.Num == other.Num && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000BF1C File Offset: 0x0000A11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000BF24 File Offset: 0x0000A124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000BF30 File Offset: 0x0000A130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ItemId);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000BF8C File Offset: 0x0000A18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideSkillItemScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000C034 File Offset: 0x0000A234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000C040 File Offset: 0x0000A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000173 RID: 371
		private static readonly MessageParser<AetherDivideSkillItemScNotify> _parser = new MessageParser<AetherDivideSkillItemScNotify>(() => new AetherDivideSkillItemScNotify());

		// Token: 0x04000174 RID: 372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000175 RID: 373
		public const int NumFieldNumber = 13;

		// Token: 0x04000176 RID: 374
		private uint num_;

		// Token: 0x04000177 RID: 375
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04000178 RID: 376
		private uint itemId_;
	}
}
