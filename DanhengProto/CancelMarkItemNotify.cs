using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000167 RID: 359
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelMarkItemNotify : IMessage<CancelMarkItemNotify>, IMessage, IEquatable<CancelMarkItemNotify>, IDeepCloneable<CancelMarkItemNotify>, IBufferMessage
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0002EA38 File Offset: 0x0002CC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelMarkItemNotify> Parser
		{
			get
			{
				return CancelMarkItemNotify._parser;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0002EA3F File Offset: 0x0002CC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelMarkItemNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0002EA51 File Offset: 0x0002CC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMarkItemNotify.Descriptor;
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0002EA58 File Offset: 0x0002CC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMarkItemNotify()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0002EA60 File Offset: 0x0002CC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMarkItemNotify(CancelMarkItemNotify other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0002EA85 File Offset: 0x0002CC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMarkItemNotify Clone()
		{
			return new CancelMarkItemNotify(this);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0002EA8D File Offset: 0x0002CC8D
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0002EA95 File Offset: 0x0002CC95
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

		// Token: 0x0600100B RID: 4107 RVA: 0x0002EA9E File Offset: 0x0002CC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMarkItemNotify);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0002EAAC File Offset: 0x0002CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMarkItemNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0002EADC File Offset: 0x0002CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600100E RID: 4110 RVA: 0x0002EB1B File Offset: 0x0002CD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0002EB23 File Offset: 0x0002CD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0002EB60 File Offset: 0x0002CD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06001012 RID: 4114 RVA: 0x0002EB9E File Offset: 0x0002CD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMarkItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0002EBCF File Offset: 0x0002CDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0002EBD8 File Offset: 0x0002CDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006C9 RID: 1737
		private static readonly MessageParser<CancelMarkItemNotify> _parser = new MessageParser<CancelMarkItemNotify>(() => new CancelMarkItemNotify());

		// Token: 0x040006CA RID: 1738
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006CB RID: 1739
		public const int ItemIdFieldNumber = 10;

		// Token: 0x040006CC RID: 1740
		private uint itemId_;
	}
}
