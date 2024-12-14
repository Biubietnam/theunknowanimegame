using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001CD RID: 461
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeScriptEmotionScRsp : IMessage<ChangeScriptEmotionScRsp>, IMessage, IEquatable<ChangeScriptEmotionScRsp>, IDeepCloneable<ChangeScriptEmotionScRsp>, IBufferMessage
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0003B6EF File Offset: 0x000398EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeScriptEmotionScRsp> Parser
		{
			get
			{
				return ChangeScriptEmotionScRsp._parser;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0003B6F6 File Offset: 0x000398F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChangeScriptEmotionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0003B708 File Offset: 0x00039908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeScriptEmotionScRsp.Descriptor;
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0003B70F File Offset: 0x0003990F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeScriptEmotionScRsp()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0003B717 File Offset: 0x00039917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeScriptEmotionScRsp(ChangeScriptEmotionScRsp other) : this()
		{
			this.emotionType_ = other.emotionType_;
			this.scriptId_ = other.scriptId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0003B754 File Offset: 0x00039954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeScriptEmotionScRsp Clone()
		{
			return new ChangeScriptEmotionScRsp(this);
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0003B75C File Offset: 0x0003995C
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0003B764 File Offset: 0x00039964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialEmotionType EmotionType
		{
			get
			{
				return this.emotionType_;
			}
			set
			{
				this.emotionType_ = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0003B76D File Offset: 0x0003996D
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0003B775 File Offset: 0x00039975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0003B77E File Offset: 0x0003997E
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0003B786 File Offset: 0x00039986
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

		// Token: 0x060014C6 RID: 5318 RVA: 0x0003B78F File Offset: 0x0003998F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeScriptEmotionScRsp);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0003B7A0 File Offset: 0x000399A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeScriptEmotionScRsp other)
		{
			return other != null && (other == this || (this.EmotionType == other.EmotionType && this.ScriptId == other.ScriptId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0003B7FC File Offset: 0x000399FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EmotionType != HeartDialEmotionType.Peace)
			{
				num ^= this.EmotionType.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
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

		// Token: 0x060014C9 RID: 5321 RVA: 0x0003B873 File Offset: 0x00039A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0003B87B File Offset: 0x00039A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0003B884 File Offset: 0x00039A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.EmotionType != HeartDialEmotionType.Peace)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.EmotionType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0003B8FC File Offset: 0x00039AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EmotionType != HeartDialEmotionType.Peace)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EmotionType);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
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

		// Token: 0x060014CD RID: 5325 RVA: 0x0003B96C File Offset: 0x00039B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeScriptEmotionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EmotionType != HeartDialEmotionType.Peace)
			{
				this.EmotionType = other.EmotionType;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0003B9D0 File Offset: 0x00039BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0003B9DC File Offset: 0x00039BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 56U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EmotionType = (HeartDialEmotionType)input.ReadEnum();
						}
					}
					else
					{
						this.ScriptId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040008AB RID: 2219
		private static readonly MessageParser<ChangeScriptEmotionScRsp> _parser = new MessageParser<ChangeScriptEmotionScRsp>(() => new ChangeScriptEmotionScRsp());

		// Token: 0x040008AC RID: 2220
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008AD RID: 2221
		public const int EmotionTypeFieldNumber = 14;

		// Token: 0x040008AE RID: 2222
		private HeartDialEmotionType emotionType_;

		// Token: 0x040008AF RID: 2223
		public const int ScriptIdFieldNumber = 7;

		// Token: 0x040008B0 RID: 2224
		private uint scriptId_;

		// Token: 0x040008B1 RID: 2225
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040008B2 RID: 2226
		private uint retcode_;
	}
}
