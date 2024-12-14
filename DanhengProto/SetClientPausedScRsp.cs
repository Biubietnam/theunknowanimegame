using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010DB RID: 4315
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetClientPausedScRsp : IMessage<SetClientPausedScRsp>, IMessage, IEquatable<SetClientPausedScRsp>, IDeepCloneable<SetClientPausedScRsp>, IBufferMessage
	{
		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600C067 RID: 49255 RVA: 0x00205B80 File Offset: 0x00203D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetClientPausedScRsp> Parser
		{
			get
			{
				return SetClientPausedScRsp._parser;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600C068 RID: 49256 RVA: 0x00205B87 File Offset: 0x00203D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetClientPausedScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600C069 RID: 49257 RVA: 0x00205B99 File Offset: 0x00203D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientPausedScRsp.Descriptor;
			}
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x00205BA0 File Offset: 0x00203DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientPausedScRsp()
		{
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x00205BA8 File Offset: 0x00203DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientPausedScRsp(SetClientPausedScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.paused_ = other.paused_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x00205BD9 File Offset: 0x00203DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientPausedScRsp Clone()
		{
			return new SetClientPausedScRsp(this);
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600C06D RID: 49261 RVA: 0x00205BE1 File Offset: 0x00203DE1
		// (set) Token: 0x0600C06E RID: 49262 RVA: 0x00205BE9 File Offset: 0x00203DE9
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

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600C06F RID: 49263 RVA: 0x00205BF2 File Offset: 0x00203DF2
		// (set) Token: 0x0600C070 RID: 49264 RVA: 0x00205BFA File Offset: 0x00203DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Paused
		{
			get
			{
				return this.paused_;
			}
			set
			{
				this.paused_ = value;
			}
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x00205C03 File Offset: 0x00203E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientPausedScRsp);
		}

		// Token: 0x0600C072 RID: 49266 RVA: 0x00205C11 File Offset: 0x00203E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientPausedScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Paused == other.Paused && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C073 RID: 49267 RVA: 0x00205C50 File Offset: 0x00203E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Paused)
			{
				num ^= this.Paused.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C074 RID: 49268 RVA: 0x00205CA8 File Offset: 0x00203EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x00205CB0 File Offset: 0x00203EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C076 RID: 49270 RVA: 0x00205CBC File Offset: 0x00203EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Paused)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Paused);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C077 RID: 49271 RVA: 0x00205D14 File Offset: 0x00203F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Paused)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C078 RID: 49272 RVA: 0x00205D60 File Offset: 0x00203F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientPausedScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Paused)
			{
				this.Paused = other.Paused;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C079 RID: 49273 RVA: 0x00205DB0 File Offset: 0x00203FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C07A RID: 49274 RVA: 0x00205DBC File Offset: 0x00203FBC
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
						this.Paused = input.ReadBool();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E06 RID: 19974
		private static readonly MessageParser<SetClientPausedScRsp> _parser = new MessageParser<SetClientPausedScRsp>(() => new SetClientPausedScRsp());

		// Token: 0x04004E07 RID: 19975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E08 RID: 19976
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04004E09 RID: 19977
		private uint retcode_;

		// Token: 0x04004E0A RID: 19978
		public const int PausedFieldNumber = 9;

		// Token: 0x04004E0B RID: 19979
		private bool paused_;
	}
}
