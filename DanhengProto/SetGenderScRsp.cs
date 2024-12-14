using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010FF RID: 4351
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetGenderScRsp : IMessage<SetGenderScRsp>, IMessage, IEquatable<SetGenderScRsp>, IDeepCloneable<SetGenderScRsp>, IBufferMessage
	{
		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600C1FF RID: 49663 RVA: 0x0020940B File Offset: 0x0020760B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetGenderScRsp> Parser
		{
			get
			{
				return SetGenderScRsp._parser;
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600C200 RID: 49664 RVA: 0x00209412 File Offset: 0x00207612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetGenderScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600C201 RID: 49665 RVA: 0x00209424 File Offset: 0x00207624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGenderScRsp.Descriptor;
			}
		}

		// Token: 0x0600C202 RID: 49666 RVA: 0x0020942B File Offset: 0x0020762B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGenderScRsp()
		{
		}

		// Token: 0x0600C203 RID: 49667 RVA: 0x00209440 File Offset: 0x00207640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGenderScRsp(SetGenderScRsp other) : this()
		{
			this.curAvatarPathInfoList_ = other.curAvatarPathInfoList_.Clone();
			this.retcode_ = other.retcode_;
			this.curAvatarPath_ = other.curAvatarPath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C204 RID: 49668 RVA: 0x0020948D File Offset: 0x0020768D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGenderScRsp Clone()
		{
			return new SetGenderScRsp(this);
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600C205 RID: 49669 RVA: 0x00209495 File Offset: 0x00207695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MultiPathAvatarInfo> CurAvatarPathInfoList
		{
			get
			{
				return this.curAvatarPathInfoList_;
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600C206 RID: 49670 RVA: 0x0020949D File Offset: 0x0020769D
		// (set) Token: 0x0600C207 RID: 49671 RVA: 0x002094A5 File Offset: 0x002076A5
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

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600C208 RID: 49672 RVA: 0x002094AE File Offset: 0x002076AE
		// (set) Token: 0x0600C209 RID: 49673 RVA: 0x002094B6 File Offset: 0x002076B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType CurAvatarPath
		{
			get
			{
				return this.curAvatarPath_;
			}
			set
			{
				this.curAvatarPath_ = value;
			}
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x002094BF File Offset: 0x002076BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGenderScRsp);
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x002094D0 File Offset: 0x002076D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetGenderScRsp other)
		{
			return other != null && (other == this || (this.curAvatarPathInfoList_.Equals(other.curAvatarPathInfoList_) && this.Retcode == other.Retcode && this.CurAvatarPath == other.CurAvatarPath && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C20C RID: 49676 RVA: 0x00209530 File Offset: 0x00207730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.curAvatarPathInfoList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurAvatarPath != MultiPathAvatarType.None)
			{
				num ^= this.CurAvatarPath.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C20D RID: 49677 RVA: 0x0020959C File Offset: 0x0020779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x002095A4 File Offset: 0x002077A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x002095B0 File Offset: 0x002077B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurAvatarPath != MultiPathAvatarType.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.CurAvatarPath);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.curAvatarPathInfoList_.WriteTo(ref output, SetGenderScRsp._repeated_curAvatarPathInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C210 RID: 49680 RVA: 0x0020961C File Offset: 0x0020781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.curAvatarPathInfoList_.CalculateSize(SetGenderScRsp._repeated_curAvatarPathInfoList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurAvatarPath != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurAvatarPath);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C211 RID: 49681 RVA: 0x00209688 File Offset: 0x00207888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetGenderScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.curAvatarPathInfoList_.Add(other.curAvatarPathInfoList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurAvatarPath != MultiPathAvatarType.None)
			{
				this.CurAvatarPath = other.CurAvatarPath;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C212 RID: 49682 RVA: 0x002096E9 File Offset: 0x002078E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C213 RID: 49683 RVA: 0x002096F4 File Offset: 0x002078F4
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
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.curAvatarPathInfoList_.AddEntriesFrom(ref input, SetGenderScRsp._repeated_curAvatarPathInfoList_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.CurAvatarPath = (MultiPathAvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004E82 RID: 20098
		private static readonly MessageParser<SetGenderScRsp> _parser = new MessageParser<SetGenderScRsp>(() => new SetGenderScRsp());

		// Token: 0x04004E83 RID: 20099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E84 RID: 20100
		public const int CurAvatarPathInfoListFieldNumber = 11;

		// Token: 0x04004E85 RID: 20101
		private static readonly FieldCodec<MultiPathAvatarInfo> _repeated_curAvatarPathInfoList_codec = FieldCodec.ForMessage<MultiPathAvatarInfo>(90U, MultiPathAvatarInfo.Parser);

		// Token: 0x04004E86 RID: 20102
		private readonly RepeatedField<MultiPathAvatarInfo> curAvatarPathInfoList_ = new RepeatedField<MultiPathAvatarInfo>();

		// Token: 0x04004E87 RID: 20103
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04004E88 RID: 20104
		private uint retcode_;

		// Token: 0x04004E89 RID: 20105
		public const int CurAvatarPathFieldNumber = 4;

		// Token: 0x04004E8A RID: 20106
		private MultiPathAvatarType curAvatarPath_;
	}
}
