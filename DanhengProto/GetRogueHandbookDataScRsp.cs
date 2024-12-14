using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007BF RID: 1983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueHandbookDataScRsp : IMessage<GetRogueHandbookDataScRsp>, IMessage, IEquatable<GetRogueHandbookDataScRsp>, IDeepCloneable<GetRogueHandbookDataScRsp>, IBufferMessage
	{
		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06005876 RID: 22646 RVA: 0x000EC6E5 File Offset: 0x000EA8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueHandbookDataScRsp> Parser
		{
			get
			{
				return GetRogueHandbookDataScRsp._parser;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06005877 RID: 22647 RVA: 0x000EC6EC File Offset: 0x000EA8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueHandbookDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06005878 RID: 22648 RVA: 0x000EC6FE File Offset: 0x000EA8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueHandbookDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x000EC705 File Offset: 0x000EA905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueHandbookDataScRsp()
		{
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x000EC710 File Offset: 0x000EA910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueHandbookDataScRsp(GetRogueHandbookDataScRsp other) : this()
		{
			this.handbookInfo_ = ((other.handbookInfo_ != null) ? other.handbookInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x000EC75C File Offset: 0x000EA95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueHandbookDataScRsp Clone()
		{
			return new GetRogueHandbookDataScRsp(this);
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600587C RID: 22652 RVA: 0x000EC764 File Offset: 0x000EA964
		// (set) Token: 0x0600587D RID: 22653 RVA: 0x000EC76C File Offset: 0x000EA96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHandbook HandbookInfo
		{
			get
			{
				return this.handbookInfo_;
			}
			set
			{
				this.handbookInfo_ = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600587E RID: 22654 RVA: 0x000EC775 File Offset: 0x000EA975
		// (set) Token: 0x0600587F RID: 22655 RVA: 0x000EC77D File Offset: 0x000EA97D
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

		// Token: 0x06005880 RID: 22656 RVA: 0x000EC786 File Offset: 0x000EA986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueHandbookDataScRsp);
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x000EC794 File Offset: 0x000EA994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueHandbookDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.HandbookInfo, other.HandbookInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x000EC7E4 File Offset: 0x000EA9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.handbookInfo_ != null)
			{
				num ^= this.HandbookInfo.GetHashCode();
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

		// Token: 0x06005883 RID: 22659 RVA: 0x000EC839 File Offset: 0x000EAA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x000EC841 File Offset: 0x000EAA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x000EC84C File Offset: 0x000EAA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handbookInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HandbookInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x000EC8A8 File Offset: 0x000EAAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.handbookInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HandbookInfo);
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

		// Token: 0x06005887 RID: 22663 RVA: 0x000EC900 File Offset: 0x000EAB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueHandbookDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.handbookInfo_ != null)
			{
				if (this.handbookInfo_ == null)
				{
					this.HandbookInfo = new RogueHandbook();
				}
				this.HandbookInfo.MergeFrom(other.HandbookInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x000EC968 File Offset: 0x000EAB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x000EC974 File Offset: 0x000EAB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 64U)
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
					if (this.handbookInfo_ == null)
					{
						this.HandbookInfo = new RogueHandbook();
					}
					input.ReadMessage(this.HandbookInfo);
				}
			}
		}

		// Token: 0x0400227A RID: 8826
		private static readonly MessageParser<GetRogueHandbookDataScRsp> _parser = new MessageParser<GetRogueHandbookDataScRsp>(() => new GetRogueHandbookDataScRsp());

		// Token: 0x0400227B RID: 8827
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400227C RID: 8828
		public const int HandbookInfoFieldNumber = 2;

		// Token: 0x0400227D RID: 8829
		private RogueHandbook handbookInfo_;

		// Token: 0x0400227E RID: 8830
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400227F RID: 8831
		private uint retcode_;
	}
}
