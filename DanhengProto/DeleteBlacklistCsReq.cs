using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200036D RID: 877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteBlacklistCsReq : IMessage<DeleteBlacklistCsReq>, IMessage, IEquatable<DeleteBlacklistCsReq>, IDeepCloneable<DeleteBlacklistCsReq>, IBufferMessage
	{
		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x0006D344 File Offset: 0x0006B544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteBlacklistCsReq> Parser
		{
			get
			{
				return DeleteBlacklistCsReq._parser;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x0006D34B File Offset: 0x0006B54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteBlacklistCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x0006D35D File Offset: 0x0006B55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteBlacklistCsReq.Descriptor;
			}
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0006D364 File Offset: 0x0006B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteBlacklistCsReq()
		{
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0006D36C File Offset: 0x0006B56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteBlacklistCsReq(DeleteBlacklistCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x0006D391 File Offset: 0x0006B591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteBlacklistCsReq Clone()
		{
			return new DeleteBlacklistCsReq(this);
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x0006D399 File Offset: 0x0006B599
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x0006D3A1 File Offset: 0x0006B5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x0006D3AA File Offset: 0x0006B5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteBlacklistCsReq);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteBlacklistCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0006D3E8 File Offset: 0x0006B5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x0006D427 File Offset: 0x0006B627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x0006D42F File Offset: 0x0006B62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0006D438 File Offset: 0x0006B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0006D46C File Offset: 0x0006B66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0006D4AA File Offset: 0x0006B6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteBlacklistCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0006D4DB File Offset: 0x0006B6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0006D4E4 File Offset: 0x0006B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000FC7 RID: 4039
		private static readonly MessageParser<DeleteBlacklistCsReq> _parser = new MessageParser<DeleteBlacklistCsReq>(() => new DeleteBlacklistCsReq());

		// Token: 0x04000FC8 RID: 4040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FC9 RID: 4041
		public const int UidFieldNumber = 11;

		// Token: 0x04000FCA RID: 4042
		private uint uid_;
	}
}
