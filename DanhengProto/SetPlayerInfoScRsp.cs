using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001123 RID: 4387
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetPlayerInfoScRsp : IMessage<SetPlayerInfoScRsp>, IMessage, IEquatable<SetPlayerInfoScRsp>, IDeepCloneable<SetPlayerInfoScRsp>, IBufferMessage
	{
		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600C39B RID: 50075 RVA: 0x0020CEE7 File Offset: 0x0020B0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetPlayerInfoScRsp> Parser
		{
			get
			{
				return SetPlayerInfoScRsp._parser;
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600C39C RID: 50076 RVA: 0x0020CEEE File Offset: 0x0020B0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetPlayerInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600C39D RID: 50077 RVA: 0x0020CF00 File Offset: 0x0020B100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPlayerInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x0020CF07 File Offset: 0x0020B107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerInfoScRsp()
		{
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x0020CF1C File Offset: 0x0020B11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerInfoScRsp(SetPlayerInfoScRsp other) : this()
		{
			this.curAvatarPath_ = other.curAvatarPath_;
			this.isModify_ = other.isModify_;
			this.curAvatarPathInfoList_ = other.curAvatarPathInfoList_.Clone();
			this.retcode_ = other.retcode_;
			this.dLFJLAJMLHJ_ = other.dLFJLAJMLHJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x0020CF81 File Offset: 0x0020B181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerInfoScRsp Clone()
		{
			return new SetPlayerInfoScRsp(this);
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600C3A1 RID: 50081 RVA: 0x0020CF89 File Offset: 0x0020B189
		// (set) Token: 0x0600C3A2 RID: 50082 RVA: 0x0020CF91 File Offset: 0x0020B191
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

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600C3A3 RID: 50083 RVA: 0x0020CF9A File Offset: 0x0020B19A
		// (set) Token: 0x0600C3A4 RID: 50084 RVA: 0x0020CFA2 File Offset: 0x0020B1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsModify
		{
			get
			{
				return this.isModify_;
			}
			set
			{
				this.isModify_ = value;
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x0020CFAB File Offset: 0x0020B1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MultiPathAvatarInfo> CurAvatarPathInfoList
		{
			get
			{
				return this.curAvatarPathInfoList_;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600C3A6 RID: 50086 RVA: 0x0020CFB3 File Offset: 0x0020B1B3
		// (set) Token: 0x0600C3A7 RID: 50087 RVA: 0x0020CFBB File Offset: 0x0020B1BB
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

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x0020CFC4 File Offset: 0x0020B1C4
		// (set) Token: 0x0600C3A9 RID: 50089 RVA: 0x0020CFCC File Offset: 0x0020B1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DLFJLAJMLHJ
		{
			get
			{
				return this.dLFJLAJMLHJ_;
			}
			set
			{
				this.dLFJLAJMLHJ_ = value;
			}
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x0020CFD5 File Offset: 0x0020B1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPlayerInfoScRsp);
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x0020CFE4 File Offset: 0x0020B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetPlayerInfoScRsp other)
		{
			return other != null && (other == this || (this.CurAvatarPath == other.CurAvatarPath && this.IsModify == other.IsModify && this.curAvatarPathInfoList_.Equals(other.curAvatarPathInfoList_) && this.Retcode == other.Retcode && this.DLFJLAJMLHJ == other.DLFJLAJMLHJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x0020D064 File Offset: 0x0020B264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurAvatarPath != MultiPathAvatarType.None)
			{
				num ^= this.CurAvatarPath.GetHashCode();
			}
			if (this.IsModify)
			{
				num ^= this.IsModify.GetHashCode();
			}
			num ^= this.curAvatarPathInfoList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.DLFJLAJMLHJ != 0L)
			{
				num ^= this.DLFJLAJMLHJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x0020D103 File Offset: 0x0020B303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x0020D10B File Offset: 0x0020B30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x0020D114 File Offset: 0x0020B314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsModify)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsModify);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.curAvatarPathInfoList_.WriteTo(ref output, SetPlayerInfoScRsp._repeated_curAvatarPathInfoList_codec);
			if (this.CurAvatarPath != MultiPathAvatarType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.CurAvatarPath);
			}
			if (this.DLFJLAJMLHJ != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.DLFJLAJMLHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x0020D1B8 File Offset: 0x0020B3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurAvatarPath != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurAvatarPath);
			}
			if (this.IsModify)
			{
				num += 2;
			}
			num += this.curAvatarPathInfoList_.CalculateSize(SetPlayerInfoScRsp._repeated_curAvatarPathInfoList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.DLFJLAJMLHJ != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DLFJLAJMLHJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x0020D248 File Offset: 0x0020B448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetPlayerInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurAvatarPath != MultiPathAvatarType.None)
			{
				this.CurAvatarPath = other.CurAvatarPath;
			}
			if (other.IsModify)
			{
				this.IsModify = other.IsModify;
			}
			this.curAvatarPathInfoList_.Add(other.curAvatarPathInfoList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.DLFJLAJMLHJ != 0L)
			{
				this.DLFJLAJMLHJ = other.DLFJLAJMLHJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x0020D2D1 File Offset: 0x0020B4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x0020D2DC File Offset: 0x0020B4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.IsModify = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.curAvatarPathInfoList_.AddEntriesFrom(ref input, SetPlayerInfoScRsp._repeated_curAvatarPathInfoList_codec);
						continue;
					}
					if (num == 104U)
					{
						this.CurAvatarPath = (MultiPathAvatarType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.DLFJLAJMLHJ = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F02 RID: 20226
		private static readonly MessageParser<SetPlayerInfoScRsp> _parser = new MessageParser<SetPlayerInfoScRsp>(() => new SetPlayerInfoScRsp());

		// Token: 0x04004F03 RID: 20227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F04 RID: 20228
		public const int CurAvatarPathFieldNumber = 13;

		// Token: 0x04004F05 RID: 20229
		private MultiPathAvatarType curAvatarPath_;

		// Token: 0x04004F06 RID: 20230
		public const int IsModifyFieldNumber = 1;

		// Token: 0x04004F07 RID: 20231
		private bool isModify_;

		// Token: 0x04004F08 RID: 20232
		public const int CurAvatarPathInfoListFieldNumber = 11;

		// Token: 0x04004F09 RID: 20233
		private static readonly FieldCodec<MultiPathAvatarInfo> _repeated_curAvatarPathInfoList_codec = FieldCodec.ForMessage<MultiPathAvatarInfo>(90U, MultiPathAvatarInfo.Parser);

		// Token: 0x04004F0A RID: 20234
		private readonly RepeatedField<MultiPathAvatarInfo> curAvatarPathInfoList_ = new RepeatedField<MultiPathAvatarInfo>();

		// Token: 0x04004F0B RID: 20235
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04004F0C RID: 20236
		private uint retcode_;

		// Token: 0x04004F0D RID: 20237
		public const int DLFJLAJMLHJFieldNumber = 14;

		// Token: 0x04004F0E RID: 20238
		private long dLFJLAJMLHJ_;
	}
}
