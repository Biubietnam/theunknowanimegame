using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D3 RID: 4307
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAvatarPathScRsp : IMessage<SetAvatarPathScRsp>, IMessage, IEquatable<SetAvatarPathScRsp>, IDeepCloneable<SetAvatarPathScRsp>, IBufferMessage
	{
		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600C00E RID: 49166 RVA: 0x00204EC9 File Offset: 0x002030C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAvatarPathScRsp> Parser
		{
			get
			{
				return SetAvatarPathScRsp._parser;
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600C00F RID: 49167 RVA: 0x00204ED0 File Offset: 0x002030D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAvatarPathScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600C010 RID: 49168 RVA: 0x00204EE2 File Offset: 0x002030E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAvatarPathScRsp.Descriptor;
			}
		}

		// Token: 0x0600C011 RID: 49169 RVA: 0x00204EE9 File Offset: 0x002030E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAvatarPathScRsp()
		{
		}

		// Token: 0x0600C012 RID: 49170 RVA: 0x00204EF1 File Offset: 0x002030F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAvatarPathScRsp(SetAvatarPathScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C013 RID: 49171 RVA: 0x00204F22 File Offset: 0x00203122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAvatarPathScRsp Clone()
		{
			return new SetAvatarPathScRsp(this);
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600C014 RID: 49172 RVA: 0x00204F2A File Offset: 0x0020312A
		// (set) Token: 0x0600C015 RID: 49173 RVA: 0x00204F32 File Offset: 0x00203132
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

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600C016 RID: 49174 RVA: 0x00204F3B File Offset: 0x0020313B
		// (set) Token: 0x0600C017 RID: 49175 RVA: 0x00204F43 File Offset: 0x00203143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType AvatarId
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

		// Token: 0x0600C018 RID: 49176 RVA: 0x00204F4C File Offset: 0x0020314C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAvatarPathScRsp);
		}

		// Token: 0x0600C019 RID: 49177 RVA: 0x00204F5A File Offset: 0x0020315A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAvatarPathScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C01A RID: 49178 RVA: 0x00204F98 File Offset: 0x00203198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C01B RID: 49179 RVA: 0x00204FF6 File Offset: 0x002031F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x00204FFE File Offset: 0x002031FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C01D RID: 49181 RVA: 0x00205008 File Offset: 0x00203208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C01E RID: 49182 RVA: 0x00205064 File Offset: 0x00203264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C01F RID: 49183 RVA: 0x002050BC File Offset: 0x002032BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAvatarPathScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AvatarId != MultiPathAvatarType.None)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C020 RID: 49184 RVA: 0x0020510C File Offset: 0x0020330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C021 RID: 49185 RVA: 0x00205118 File Offset: 0x00203318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = (MultiPathAvatarType)input.ReadEnum();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004DEB RID: 19947
		private static readonly MessageParser<SetAvatarPathScRsp> _parser = new MessageParser<SetAvatarPathScRsp>(() => new SetAvatarPathScRsp());

		// Token: 0x04004DEC RID: 19948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DED RID: 19949
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04004DEE RID: 19950
		private uint retcode_;

		// Token: 0x04004DEF RID: 19951
		public const int AvatarIdFieldNumber = 15;

		// Token: 0x04004DF0 RID: 19952
		private MultiPathAvatarType avatarId_;
	}
}
