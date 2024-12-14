using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003DD RID: 989
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DressRelicParam : IMessage<DressRelicParam>, IMessage, IEquatable<DressRelicParam>, IDeepCloneable<DressRelicParam>, IBufferMessage
	{
		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x0007A3AC File Offset: 0x000785AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DressRelicParam> Parser
		{
			get
			{
				return DressRelicParam._parser;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x0007A3B3 File Offset: 0x000785B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DressRelicParamReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x0007A3C5 File Offset: 0x000785C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressRelicParam.Descriptor;
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x0007A3CC File Offset: 0x000785CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicParam()
		{
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0007A3D4 File Offset: 0x000785D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicParam(DressRelicParam other) : this()
		{
			this.relicUniqueId_ = other.relicUniqueId_;
			this.relicType_ = other.relicType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0007A405 File Offset: 0x00078605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressRelicParam Clone()
		{
			return new DressRelicParam(this);
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x0007A40D File Offset: 0x0007860D
		// (set) Token: 0x06002C09 RID: 11273 RVA: 0x0007A415 File Offset: 0x00078615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RelicUniqueId
		{
			get
			{
				return this.relicUniqueId_;
			}
			set
			{
				this.relicUniqueId_ = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x0007A41E File Offset: 0x0007861E
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x0007A426 File Offset: 0x00078626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RelicType
		{
			get
			{
				return this.relicType_;
			}
			set
			{
				this.relicType_ = value;
			}
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x0007A42F File Offset: 0x0007862F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressRelicParam);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0007A43D File Offset: 0x0007863D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressRelicParam other)
		{
			return other != null && (other == this || (this.RelicUniqueId == other.RelicUniqueId && this.RelicType == other.RelicType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0007A47C File Offset: 0x0007867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RelicUniqueId != 0U)
			{
				num ^= this.RelicUniqueId.GetHashCode();
			}
			if (this.RelicType != 0U)
			{
				num ^= this.RelicType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0007A4D4 File Offset: 0x000786D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0007A4DC File Offset: 0x000786DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0007A4E8 File Offset: 0x000786E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RelicType != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RelicType);
			}
			if (this.RelicUniqueId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.RelicUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0007A544 File Offset: 0x00078744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RelicUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RelicUniqueId);
			}
			if (this.RelicType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RelicType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0007A59C File Offset: 0x0007879C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressRelicParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RelicUniqueId != 0U)
			{
				this.RelicUniqueId = other.RelicUniqueId;
			}
			if (other.RelicType != 0U)
			{
				this.RelicType = other.RelicType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x0007A5EC File Offset: 0x000787EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0007A5F8 File Offset: 0x000787F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RelicUniqueId = input.ReadUInt32();
					}
				}
				else
				{
					this.RelicType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011CA RID: 4554
		private static readonly MessageParser<DressRelicParam> _parser = new MessageParser<DressRelicParam>(() => new DressRelicParam());

		// Token: 0x040011CB RID: 4555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011CC RID: 4556
		public const int RelicUniqueIdFieldNumber = 11;

		// Token: 0x040011CD RID: 4557
		private uint relicUniqueId_;

		// Token: 0x040011CE RID: 4558
		public const int RelicTypeFieldNumber = 3;

		// Token: 0x040011CF RID: 4559
		private uint relicType_;
	}
}
