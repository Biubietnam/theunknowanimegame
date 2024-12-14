using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000335 RID: 821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageUnlockScRsp : IMessage<ContentPackageUnlockScRsp>, IMessage, IEquatable<ContentPackageUnlockScRsp>, IDeepCloneable<ContentPackageUnlockScRsp>, IBufferMessage
	{
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x00067B29 File Offset: 0x00065D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageUnlockScRsp> Parser
		{
			get
			{
				return ContentPackageUnlockScRsp._parser;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x00067B30 File Offset: 0x00065D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageUnlockScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x00067B42 File Offset: 0x00065D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageUnlockScRsp.Descriptor;
			}
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00067B49 File Offset: 0x00065D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageUnlockScRsp()
		{
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00067B51 File Offset: 0x00065D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageUnlockScRsp(ContentPackageUnlockScRsp other) : this()
		{
			this.contentId_ = other.contentId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00067B82 File Offset: 0x00065D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageUnlockScRsp Clone()
		{
			return new ContentPackageUnlockScRsp(this);
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x00067B8A File Offset: 0x00065D8A
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00067B92 File Offset: 0x00065D92
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x00067B9B File Offset: 0x00065D9B
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x00067BA3 File Offset: 0x00065DA3
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

		// Token: 0x060024BB RID: 9403 RVA: 0x00067BAC File Offset: 0x00065DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageUnlockScRsp);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00067BBA File Offset: 0x00065DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageUnlockScRsp other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00067BF8 File Offset: 0x00065DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
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

		// Token: 0x060024BE RID: 9406 RVA: 0x00067C50 File Offset: 0x00065E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00067C58 File Offset: 0x00065E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00067C64 File Offset: 0x00065E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ContentId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00067CC0 File Offset: 0x00065EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
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

		// Token: 0x060024C2 RID: 9410 RVA: 0x00067D18 File Offset: 0x00065F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageUnlockScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00067D68 File Offset: 0x00065F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00067D74 File Offset: 0x00065F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 80U)
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
					this.ContentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000EF9 RID: 3833
		private static readonly MessageParser<ContentPackageUnlockScRsp> _parser = new MessageParser<ContentPackageUnlockScRsp>(() => new ContentPackageUnlockScRsp());

		// Token: 0x04000EFA RID: 3834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EFB RID: 3835
		public const int ContentIdFieldNumber = 4;

		// Token: 0x04000EFC RID: 3836
		private uint contentId_;

		// Token: 0x04000EFD RID: 3837
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04000EFE RID: 3838
		private uint retcode_;
	}
}
