using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C5 RID: 1733
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendDevelopmentInfoCsReq : IMessage<GetFriendDevelopmentInfoCsReq>, IMessage, IEquatable<GetFriendDevelopmentInfoCsReq>, IDeepCloneable<GetFriendDevelopmentInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06004D91 RID: 19857 RVA: 0x000D2384 File Offset: 0x000D0584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendDevelopmentInfoCsReq> Parser
		{
			get
			{
				return GetFriendDevelopmentInfoCsReq._parser;
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x000D238B File Offset: 0x000D058B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendDevelopmentInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004D93 RID: 19859 RVA: 0x000D239D File Offset: 0x000D059D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendDevelopmentInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x000D23A4 File Offset: 0x000D05A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendDevelopmentInfoCsReq()
		{
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x000D23AC File Offset: 0x000D05AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendDevelopmentInfoCsReq(GetFriendDevelopmentInfoCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x000D23D1 File Offset: 0x000D05D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendDevelopmentInfoCsReq Clone()
		{
			return new GetFriendDevelopmentInfoCsReq(this);
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x000D23D9 File Offset: 0x000D05D9
		// (set) Token: 0x06004D98 RID: 19864 RVA: 0x000D23E1 File Offset: 0x000D05E1
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

		// Token: 0x06004D99 RID: 19865 RVA: 0x000D23EA File Offset: 0x000D05EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendDevelopmentInfoCsReq);
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x000D23F8 File Offset: 0x000D05F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendDevelopmentInfoCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x000D2428 File Offset: 0x000D0628
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

		// Token: 0x06004D9C RID: 19868 RVA: 0x000D2467 File Offset: 0x000D0667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x000D246F File Offset: 0x000D066F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x000D2478 File Offset: 0x000D0678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x000D24AC File Offset: 0x000D06AC
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

		// Token: 0x06004DA0 RID: 19872 RVA: 0x000D24EA File Offset: 0x000D06EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendDevelopmentInfoCsReq other)
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

		// Token: 0x06004DA1 RID: 19873 RVA: 0x000D251B File Offset: 0x000D071B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x000D2524 File Offset: 0x000D0724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001EAD RID: 7853
		private static readonly MessageParser<GetFriendDevelopmentInfoCsReq> _parser = new MessageParser<GetFriendDevelopmentInfoCsReq>(() => new GetFriendDevelopmentInfoCsReq());

		// Token: 0x04001EAE RID: 7854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EAF RID: 7855
		public const int UidFieldNumber = 8;

		// Token: 0x04001EB0 RID: 7856
		private uint uid_;
	}
}
