using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001157 RID: 4439
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SocialEventServerCache : IMessage<SocialEventServerCache>, IMessage, IEquatable<SocialEventServerCache>, IDeepCloneable<SocialEventServerCache>, IBufferMessage
	{
		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600C604 RID: 50692 RVA: 0x00213825 File Offset: 0x00211A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SocialEventServerCache> Parser
		{
			get
			{
				return SocialEventServerCache._parser;
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600C605 RID: 50693 RVA: 0x0021382C File Offset: 0x00211A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialEventServerCacheReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600C606 RID: 50694 RVA: 0x0021383E File Offset: 0x00211A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SocialEventServerCache.Descriptor;
			}
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x00213845 File Offset: 0x00211A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialEventServerCache()
		{
		}

		// Token: 0x0600C608 RID: 50696 RVA: 0x00213850 File Offset: 0x00211A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialEventServerCache(SocialEventServerCache other) : this()
		{
			this.id_ = other.id_;
			this.addCoin_ = other.addCoin_;
			this.subCoin_ = other.subCoin_;
			this.srcUid_ = other.srcUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C609 RID: 50697 RVA: 0x002138A4 File Offset: 0x00211AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialEventServerCache Clone()
		{
			return new SocialEventServerCache(this);
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600C60A RID: 50698 RVA: 0x002138AC File Offset: 0x00211AAC
		// (set) Token: 0x0600C60B RID: 50699 RVA: 0x002138B4 File Offset: 0x00211AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600C60C RID: 50700 RVA: 0x002138BD File Offset: 0x00211ABD
		// (set) Token: 0x0600C60D RID: 50701 RVA: 0x002138C5 File Offset: 0x00211AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AddCoin
		{
			get
			{
				return this.addCoin_;
			}
			set
			{
				this.addCoin_ = value;
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600C60E RID: 50702 RVA: 0x002138CE File Offset: 0x00211ACE
		// (set) Token: 0x0600C60F RID: 50703 RVA: 0x002138D6 File Offset: 0x00211AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubCoin
		{
			get
			{
				return this.subCoin_;
			}
			set
			{
				this.subCoin_ = value;
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600C610 RID: 50704 RVA: 0x002138DF File Offset: 0x00211ADF
		// (set) Token: 0x0600C611 RID: 50705 RVA: 0x002138E7 File Offset: 0x00211AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SrcUid
		{
			get
			{
				return this.srcUid_;
			}
			set
			{
				this.srcUid_ = value;
			}
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x002138F0 File Offset: 0x00211AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SocialEventServerCache);
		}

		// Token: 0x0600C613 RID: 50707 RVA: 0x00213900 File Offset: 0x00211B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SocialEventServerCache other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.AddCoin == other.AddCoin && this.SubCoin == other.SubCoin && this.SrcUid == other.SrcUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C614 RID: 50708 RVA: 0x0021396C File Offset: 0x00211B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.AddCoin != 0U)
			{
				num ^= this.AddCoin.GetHashCode();
			}
			if (this.SubCoin != 0U)
			{
				num ^= this.SubCoin.GetHashCode();
			}
			if (this.SrcUid != 0U)
			{
				num ^= this.SrcUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C615 RID: 50709 RVA: 0x002139F6 File Offset: 0x00211BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x002139FE File Offset: 0x00211BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x00213A08 File Offset: 0x00211C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this.SrcUid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.SrcUid);
			}
			if (this.SubCoin != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.SubCoin);
			}
			if (this.AddCoin != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.AddCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C618 RID: 50712 RVA: 0x00213A9C File Offset: 0x00211C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.AddCoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AddCoin);
			}
			if (this.SubCoin != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubCoin);
			}
			if (this.SrcUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SrcUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C619 RID: 50713 RVA: 0x00213B24 File Offset: 0x00211D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SocialEventServerCache other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.AddCoin != 0U)
			{
				this.AddCoin = other.AddCoin;
			}
			if (other.SubCoin != 0U)
			{
				this.SubCoin = other.SubCoin;
			}
			if (other.SrcUid != 0U)
			{
				this.SrcUid = other.SrcUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C61A RID: 50714 RVA: 0x00213B9C File Offset: 0x00211D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C61B RID: 50715 RVA: 0x00213BA8 File Offset: 0x00211DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.SrcUid = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.SubCoin = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.AddCoin = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FFE RID: 20478
		private static readonly MessageParser<SocialEventServerCache> _parser = new MessageParser<SocialEventServerCache>(() => new SocialEventServerCache());

		// Token: 0x04004FFF RID: 20479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005000 RID: 20480
		public const int IdFieldNumber = 3;

		// Token: 0x04005001 RID: 20481
		private uint id_;

		// Token: 0x04005002 RID: 20482
		public const int AddCoinFieldNumber = 13;

		// Token: 0x04005003 RID: 20483
		private uint addCoin_;

		// Token: 0x04005004 RID: 20484
		public const int SubCoinFieldNumber = 11;

		// Token: 0x04005005 RID: 20485
		private uint subCoin_;

		// Token: 0x04005006 RID: 20486
		public const int SrcUidFieldNumber = 7;

		// Token: 0x04005007 RID: 20487
		private uint srcUid_;
	}
}
