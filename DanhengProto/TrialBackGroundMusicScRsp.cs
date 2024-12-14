using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013A9 RID: 5033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrialBackGroundMusicScRsp : IMessage<TrialBackGroundMusicScRsp>, IMessage, IEquatable<TrialBackGroundMusicScRsp>, IDeepCloneable<TrialBackGroundMusicScRsp>, IBufferMessage
	{
		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0600E090 RID: 57488 RVA: 0x00256009 File Offset: 0x00254209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrialBackGroundMusicScRsp> Parser
		{
			get
			{
				return TrialBackGroundMusicScRsp._parser;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0600E091 RID: 57489 RVA: 0x00256010 File Offset: 0x00254210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrialBackGroundMusicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0600E092 RID: 57490 RVA: 0x00256022 File Offset: 0x00254222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialBackGroundMusicScRsp.Descriptor;
			}
		}

		// Token: 0x0600E093 RID: 57491 RVA: 0x00256029 File Offset: 0x00254229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialBackGroundMusicScRsp()
		{
		}

		// Token: 0x0600E094 RID: 57492 RVA: 0x00256031 File Offset: 0x00254231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialBackGroundMusicScRsp(TrialBackGroundMusicScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.hILGIGJMIFM_ = other.hILGIGJMIFM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x00256062 File Offset: 0x00254262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialBackGroundMusicScRsp Clone()
		{
			return new TrialBackGroundMusicScRsp(this);
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0600E096 RID: 57494 RVA: 0x0025606A File Offset: 0x0025426A
		// (set) Token: 0x0600E097 RID: 57495 RVA: 0x00256072 File Offset: 0x00254272
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

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0600E098 RID: 57496 RVA: 0x0025607B File Offset: 0x0025427B
		// (set) Token: 0x0600E099 RID: 57497 RVA: 0x00256083 File Offset: 0x00254283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HILGIGJMIFM
		{
			get
			{
				return this.hILGIGJMIFM_;
			}
			set
			{
				this.hILGIGJMIFM_ = value;
			}
		}

		// Token: 0x0600E09A RID: 57498 RVA: 0x0025608C File Offset: 0x0025428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialBackGroundMusicScRsp);
		}

		// Token: 0x0600E09B RID: 57499 RVA: 0x0025609A File Offset: 0x0025429A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialBackGroundMusicScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.HILGIGJMIFM == other.HILGIGJMIFM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x002560D8 File Offset: 0x002542D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.HILGIGJMIFM != 0U)
			{
				num ^= this.HILGIGJMIFM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x00256130 File Offset: 0x00254330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x00256138 File Offset: 0x00254338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E09F RID: 57503 RVA: 0x00256144 File Offset: 0x00254344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.HILGIGJMIFM != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.HILGIGJMIFM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x002561A0 File Offset: 0x002543A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.HILGIGJMIFM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HILGIGJMIFM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0A1 RID: 57505 RVA: 0x002561F8 File Offset: 0x002543F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialBackGroundMusicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.HILGIGJMIFM != 0U)
			{
				this.HILGIGJMIFM = other.HILGIGJMIFM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0A2 RID: 57506 RVA: 0x00256248 File Offset: 0x00254448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0A3 RID: 57507 RVA: 0x00256254 File Offset: 0x00254454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HILGIGJMIFM = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400596E RID: 22894
		private static readonly MessageParser<TrialBackGroundMusicScRsp> _parser = new MessageParser<TrialBackGroundMusicScRsp>(() => new TrialBackGroundMusicScRsp());

		// Token: 0x0400596F RID: 22895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005970 RID: 22896
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04005971 RID: 22897
		private uint retcode_;

		// Token: 0x04005972 RID: 22898
		public const int HILGIGJMIFMFieldNumber = 8;

		// Token: 0x04005973 RID: 22899
		private uint hILGIGJMIFM_;
	}
}
