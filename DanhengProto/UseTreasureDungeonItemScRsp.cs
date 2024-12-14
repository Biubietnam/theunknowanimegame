using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200140F RID: 5135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UseTreasureDungeonItemScRsp : IMessage<UseTreasureDungeonItemScRsp>, IMessage, IEquatable<UseTreasureDungeonItemScRsp>, IDeepCloneable<UseTreasureDungeonItemScRsp>, IBufferMessage
	{
		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x0600E512 RID: 58642 RVA: 0x002612DF File Offset: 0x0025F4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UseTreasureDungeonItemScRsp> Parser
		{
			get
			{
				return UseTreasureDungeonItemScRsp._parser;
			}
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x0600E513 RID: 58643 RVA: 0x002612E6 File Offset: 0x0025F4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UseTreasureDungeonItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x0600E514 RID: 58644 RVA: 0x002612F8 File Offset: 0x0025F4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseTreasureDungeonItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x002612FF File Offset: 0x0025F4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseTreasureDungeonItemScRsp()
		{
		}

		// Token: 0x0600E516 RID: 58646 RVA: 0x00261308 File Offset: 0x0025F508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseTreasureDungeonItemScRsp(UseTreasureDungeonItemScRsp other) : this()
		{
			this.lHIECKPJNFD_ = ((other.lHIECKPJNFD_ != null) ? other.lHIECKPJNFD_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E517 RID: 58647 RVA: 0x00261354 File Offset: 0x0025F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseTreasureDungeonItemScRsp Clone()
		{
			return new UseTreasureDungeonItemScRsp(this);
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x0600E518 RID: 58648 RVA: 0x0026135C File Offset: 0x0025F55C
		// (set) Token: 0x0600E519 RID: 58649 RVA: 0x00261364 File Offset: 0x0025F564
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

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x0026136D File Offset: 0x0025F56D
		// (set) Token: 0x0600E51B RID: 58651 RVA: 0x00261375 File Offset: 0x0025F575
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

		// Token: 0x0600E51C RID: 58652 RVA: 0x0026137E File Offset: 0x0025F57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseTreasureDungeonItemScRsp);
		}

		// Token: 0x0600E51D RID: 58653 RVA: 0x0026138C File Offset: 0x0025F58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseTreasureDungeonItemScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LHIECKPJNFD, other.LHIECKPJNFD) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E51E RID: 58654 RVA: 0x002613DC File Offset: 0x0025F5DC
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

		// Token: 0x0600E51F RID: 58655 RVA: 0x00261431 File Offset: 0x0025F631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E520 RID: 58656 RVA: 0x00261439 File Offset: 0x0025F639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E521 RID: 58657 RVA: 0x00261444 File Offset: 0x0025F644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lHIECKPJNFD_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.LHIECKPJNFD);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E522 RID: 58658 RVA: 0x002614A0 File Offset: 0x0025F6A0
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

		// Token: 0x0600E523 RID: 58659 RVA: 0x002614F8 File Offset: 0x0025F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseTreasureDungeonItemScRsp other)
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

		// Token: 0x0600E524 RID: 58660 RVA: 0x00261560 File Offset: 0x0025F760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E525 RID: 58661 RVA: 0x0026156C File Offset: 0x0025F76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 56U)
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

		// Token: 0x04005B00 RID: 23296
		private static readonly MessageParser<UseTreasureDungeonItemScRsp> _parser = new MessageParser<UseTreasureDungeonItemScRsp>(() => new UseTreasureDungeonItemScRsp());

		// Token: 0x04005B01 RID: 23297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B02 RID: 23298
		public const int LHIECKPJNFDFieldNumber = 5;

		// Token: 0x04005B03 RID: 23299
		private TreasureDungeonLevel lHIECKPJNFD_;

		// Token: 0x04005B04 RID: 23300
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04005B05 RID: 23301
		private uint retcode_;
	}
}
