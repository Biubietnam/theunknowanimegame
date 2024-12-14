using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000533 RID: 1331
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightFestUpdateCoinNotify : IMessage<FightFestUpdateCoinNotify>, IMessage, IEquatable<FightFestUpdateCoinNotify>, IDeepCloneable<FightFestUpdateCoinNotify>, IBufferMessage
	{
		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x000A395C File Offset: 0x000A1B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFestUpdateCoinNotify> Parser
		{
			get
			{
				return FightFestUpdateCoinNotify._parser;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x000A3963 File Offset: 0x000A1B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightFestUpdateCoinNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x000A3975 File Offset: 0x000A1B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFestUpdateCoinNotify.Descriptor;
			}
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x000A397C File Offset: 0x000A1B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUpdateCoinNotify()
		{
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x000A3984 File Offset: 0x000A1B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUpdateCoinNotify(FightFestUpdateCoinNotify other) : this()
		{
			this.itemValue_ = other.itemValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x000A39A9 File Offset: 0x000A1BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestUpdateCoinNotify Clone()
		{
			return new FightFestUpdateCoinNotify(this);
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x000A39B1 File Offset: 0x000A1BB1
		// (set) Token: 0x06003B86 RID: 15238 RVA: 0x000A39B9 File Offset: 0x000A1BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemValue
		{
			get
			{
				return this.itemValue_;
			}
			set
			{
				this.itemValue_ = value;
			}
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x000A39C2 File Offset: 0x000A1BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFestUpdateCoinNotify);
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x000A39D0 File Offset: 0x000A1BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFestUpdateCoinNotify other)
		{
			return other != null && (other == this || (this.ItemValue == other.ItemValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x000A3A00 File Offset: 0x000A1C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemValue != 0U)
			{
				num ^= this.ItemValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x000A3A3F File Offset: 0x000A1C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x000A3A47 File Offset: 0x000A1C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x000A3A50 File Offset: 0x000A1C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemValue != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x000A3A84 File Offset: 0x000A1C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x000A3AC2 File Offset: 0x000A1CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightFestUpdateCoinNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemValue != 0U)
			{
				this.ItemValue = other.ItemValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x000A3AF3 File Offset: 0x000A1CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x000A3AFC File Offset: 0x000A1CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemValue = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040017F1 RID: 6129
		private static readonly MessageParser<FightFestUpdateCoinNotify> _parser = new MessageParser<FightFestUpdateCoinNotify>(() => new FightFestUpdateCoinNotify());

		// Token: 0x040017F2 RID: 6130
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017F3 RID: 6131
		public const int ItemValueFieldNumber = 6;

		// Token: 0x040017F4 RID: 6132
		private uint itemValue_;
	}
}
