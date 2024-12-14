using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C71 RID: 3185
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OpenTreasureDungeonGridScRsp : IMessage<OpenTreasureDungeonGridScRsp>, IMessage, IEquatable<OpenTreasureDungeonGridScRsp>, IDeepCloneable<OpenTreasureDungeonGridScRsp>, IBufferMessage
	{
		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x06008D8D RID: 36237 RVA: 0x001762EB File Offset: 0x001744EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OpenTreasureDungeonGridScRsp> Parser
		{
			get
			{
				return OpenTreasureDungeonGridScRsp._parser;
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x06008D8E RID: 36238 RVA: 0x001762F2 File Offset: 0x001744F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OpenTreasureDungeonGridScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x06008D8F RID: 36239 RVA: 0x00176304 File Offset: 0x00174504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenTreasureDungeonGridScRsp.Descriptor;
			}
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x0017630B File Offset: 0x0017450B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenTreasureDungeonGridScRsp()
		{
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x00176314 File Offset: 0x00174514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenTreasureDungeonGridScRsp(OpenTreasureDungeonGridScRsp other) : this()
		{
			this.lHIECKPJNFD_ = ((other.lHIECKPJNFD_ != null) ? other.lHIECKPJNFD_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x00176360 File Offset: 0x00174560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenTreasureDungeonGridScRsp Clone()
		{
			return new OpenTreasureDungeonGridScRsp(this);
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x06008D93 RID: 36243 RVA: 0x00176368 File Offset: 0x00174568
		// (set) Token: 0x06008D94 RID: 36244 RVA: 0x00176370 File Offset: 0x00174570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonLevel LHIECKPJNFD
		{
			get
			{
				return this.lHIECKPJNFD_;
			}
			set
			{
				this.lHIECKPJNFD_ = value;
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x06008D95 RID: 36245 RVA: 0x00176379 File Offset: 0x00174579
		// (set) Token: 0x06008D96 RID: 36246 RVA: 0x00176381 File Offset: 0x00174581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x0017638A File Offset: 0x0017458A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenTreasureDungeonGridScRsp);
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x00176398 File Offset: 0x00174598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenTreasureDungeonGridScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LHIECKPJNFD, other.LHIECKPJNFD) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x001763E8 File Offset: 0x001745E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lHIECKPJNFD_ != null)
			{
				num ^= this.LHIECKPJNFD.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x0017643D File Offset: 0x0017463D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x00176445 File Offset: 0x00174645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x00176450 File Offset: 0x00174650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lHIECKPJNFD_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LHIECKPJNFD);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x001764AC File Offset: 0x001746AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lHIECKPJNFD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LHIECKPJNFD);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x00176504 File Offset: 0x00174704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenTreasureDungeonGridScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lHIECKPJNFD_ != null)
			{
				if (this.lHIECKPJNFD_ == null)
				{
					this.LHIECKPJNFD = new TreasureDungeonLevel();
				}
				this.LHIECKPJNFD.MergeFrom(other.LHIECKPJNFD);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x0017656C File Offset: 0x0017476C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x00176578 File Offset: 0x00174778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.lHIECKPJNFD_ == null)
					{
						this.LHIECKPJNFD = new TreasureDungeonLevel();
					}
					input.ReadMessage(this.LHIECKPJNFD);
				}
			}
		}

		// Token: 0x0400365D RID: 13917
		private static readonly MessageParser<OpenTreasureDungeonGridScRsp> _parser = new MessageParser<OpenTreasureDungeonGridScRsp>(() => new OpenTreasureDungeonGridScRsp());

		// Token: 0x0400365E RID: 13918
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400365F RID: 13919
		public const int LHIECKPJNFDFieldNumber = 4;

		// Token: 0x04003660 RID: 13920
		private TreasureDungeonLevel lHIECKPJNFD_;

		// Token: 0x04003661 RID: 13921
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04003662 RID: 13922
		private uint retcode_;
	}
}
