using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005CF RID: 1487
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GachaCeilingAvatar : IMessage<GachaCeilingAvatar>, IMessage, IEquatable<GachaCeilingAvatar>, IDeepCloneable<GachaCeilingAvatar>, IBufferMessage
	{
		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x000B4978 File Offset: 0x000B2B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaCeilingAvatar> Parser
		{
			get
			{
				return GachaCeilingAvatar._parser;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x000B497F File Offset: 0x000B2B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GachaCeilingAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x000B4991 File Offset: 0x000B2B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaCeilingAvatar.Descriptor;
			}
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x000B4998 File Offset: 0x000B2B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeilingAvatar()
		{
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x000B49A0 File Offset: 0x000B2BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeilingAvatar(GachaCeilingAvatar other) : this()
		{
			this.repeatedCnt_ = other.repeatedCnt_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x000B49D1 File Offset: 0x000B2BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeilingAvatar Clone()
		{
			return new GachaCeilingAvatar(this);
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x000B49D9 File Offset: 0x000B2BD9
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x000B49E1 File Offset: 0x000B2BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RepeatedCnt
		{
			get
			{
				return this.repeatedCnt_;
			}
			set
			{
				this.repeatedCnt_ = value;
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x000B49EA File Offset: 0x000B2BEA
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x000B49F2 File Offset: 0x000B2BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x000B49FB File Offset: 0x000B2BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaCeilingAvatar);
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x000B4A09 File Offset: 0x000B2C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaCeilingAvatar other)
		{
			return other != null && (other == this || (this.RepeatedCnt == other.RepeatedCnt && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x000B4A48 File Offset: 0x000B2C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RepeatedCnt != 0U)
			{
				num ^= this.RepeatedCnt.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x000B4AA0 File Offset: 0x000B2CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x000B4AA8 File Offset: 0x000B2CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x000B4AB4 File Offset: 0x000B2CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RepeatedCnt != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.RepeatedCnt);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x000B4B10 File Offset: 0x000B2D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RepeatedCnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RepeatedCnt);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x000B4B68 File Offset: 0x000B2D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaCeilingAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RepeatedCnt != 0U)
			{
				this.RepeatedCnt = other.RepeatedCnt;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x000B4BB8 File Offset: 0x000B2DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.RepeatedCnt = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A56 RID: 6742
		private static readonly MessageParser<GachaCeilingAvatar> _parser = new MessageParser<GachaCeilingAvatar>(() => new GachaCeilingAvatar());

		// Token: 0x04001A57 RID: 6743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A58 RID: 6744
		public const int RepeatedCntFieldNumber = 9;

		// Token: 0x04001A59 RID: 6745
		private uint repeatedCnt_;

		// Token: 0x04001A5A RID: 6746
		public const int AvatarIdFieldNumber = 13;

		// Token: 0x04001A5B RID: 6747
		private uint avatarId_;
	}
}
