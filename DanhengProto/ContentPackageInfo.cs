using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200032B RID: 811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageInfo : IMessage<ContentPackageInfo>, IMessage, IEquatable<ContentPackageInfo>, IDeepCloneable<ContentPackageInfo>, IBufferMessage
	{
		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x00067089 File Offset: 0x00065289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageInfo> Parser
		{
			get
			{
				return ContentPackageInfo._parser;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00067090 File Offset: 0x00065290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000670A2 File Offset: 0x000652A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageInfo.Descriptor;
			}
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x000670A9 File Offset: 0x000652A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageInfo()
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x000670B1 File Offset: 0x000652B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageInfo(ContentPackageInfo other) : this()
		{
			this.contentId_ = other.contentId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x000670E2 File Offset: 0x000652E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageInfo Clone()
		{
			return new ContentPackageInfo(this);
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000670EA File Offset: 0x000652EA
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x000670F2 File Offset: 0x000652F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000670FB File Offset: 0x000652FB
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x00067103 File Offset: 0x00065303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0006710C File Offset: 0x0006530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageInfo);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0006711A File Offset: 0x0006531A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageInfo other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00067158 File Offset: 0x00065358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this.Status != ContentPackageStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000671B6 File Offset: 0x000653B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x000671BE File Offset: 0x000653BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x000671C8 File Offset: 0x000653C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ContentId);
			}
			if (this.Status != ContentPackageStatus.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00067220 File Offset: 0x00065420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this.Status != ContentPackageStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00067278 File Offset: 0x00065478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			if (other.Status != ContentPackageStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000672C8 File Offset: 0x000654C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000672D4 File Offset: 0x000654D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (ContentPackageStatus)input.ReadEnum();
					}
				}
				else
				{
					this.ContentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000EDE RID: 3806
		private static readonly MessageParser<ContentPackageInfo> _parser = new MessageParser<ContentPackageInfo>(() => new ContentPackageInfo());

		// Token: 0x04000EDF RID: 3807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EE0 RID: 3808
		public const int ContentIdFieldNumber = 1;

		// Token: 0x04000EE1 RID: 3809
		private uint contentId_;

		// Token: 0x04000EE2 RID: 3810
		public const int StatusFieldNumber = 9;

		// Token: 0x04000EE3 RID: 3811
		private ContentPackageStatus status_;
	}
}
