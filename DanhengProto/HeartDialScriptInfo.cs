using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A3 RID: 2211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeartDialScriptInfo : IMessage<HeartDialScriptInfo>, IMessage, IEquatable<HeartDialScriptInfo>, IDeepCloneable<HeartDialScriptInfo>, IBufferMessage
	{
		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x0600629A RID: 25242 RVA: 0x00107F03 File Offset: 0x00106103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeartDialScriptInfo> Parser
		{
			get
			{
				return HeartDialScriptInfo._parser;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600629B RID: 25243 RVA: 0x00107F0A File Offset: 0x0010610A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeartDialScriptInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x0600629C RID: 25244 RVA: 0x00107F1C File Offset: 0x0010611C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartDialScriptInfo.Descriptor;
			}
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x00107F23 File Offset: 0x00106123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialScriptInfo()
		{
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x00107F2C File Offset: 0x0010612C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialScriptInfo(HeartDialScriptInfo other) : this()
		{
			this.lCOAGNJBCKG_ = other.lCOAGNJBCKG_;
			this.gGFKEIJJLCE_ = other.gGFKEIJJLCE_;
			this.scriptId_ = other.scriptId_;
			this.step_ = other.step_;
			this.curEmotionType_ = other.curEmotionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x00107F8C File Offset: 0x0010618C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialScriptInfo Clone()
		{
			return new HeartDialScriptInfo(this);
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00107F94 File Offset: 0x00106194
		// (set) Token: 0x060062A1 RID: 25249 RVA: 0x00107F9C File Offset: 0x0010619C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LCOAGNJBCKG
		{
			get
			{
				return this.lCOAGNJBCKG_;
			}
			set
			{
				this.lCOAGNJBCKG_ = value;
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x060062A2 RID: 25250 RVA: 0x00107FA5 File Offset: 0x001061A5
		// (set) Token: 0x060062A3 RID: 25251 RVA: 0x00107FAD File Offset: 0x001061AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GGFKEIJJLCE
		{
			get
			{
				return this.gGFKEIJJLCE_;
			}
			set
			{
				this.gGFKEIJJLCE_ = value;
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x060062A4 RID: 25252 RVA: 0x00107FB6 File Offset: 0x001061B6
		// (set) Token: 0x060062A5 RID: 25253 RVA: 0x00107FBE File Offset: 0x001061BE
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060062A6 RID: 25254 RVA: 0x00107FC7 File Offset: 0x001061C7
		// (set) Token: 0x060062A7 RID: 25255 RVA: 0x00107FCF File Offset: 0x001061CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialStepType Step
		{
			get
			{
				return this.step_;
			}
			set
			{
				this.step_ = value;
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060062A8 RID: 25256 RVA: 0x00107FD8 File Offset: 0x001061D8
		// (set) Token: 0x060062A9 RID: 25257 RVA: 0x00107FE0 File Offset: 0x001061E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialEmotionType CurEmotionType
		{
			get
			{
				return this.curEmotionType_;
			}
			set
			{
				this.curEmotionType_ = value;
			}
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00107FE9 File Offset: 0x001061E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartDialScriptInfo);
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00107FF8 File Offset: 0x001061F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartDialScriptInfo other)
		{
			return other != null && (other == this || (this.LCOAGNJBCKG == other.LCOAGNJBCKG && this.GGFKEIJJLCE == other.GGFKEIJJLCE && this.ScriptId == other.ScriptId && this.Step == other.Step && this.CurEmotionType == other.CurEmotionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00108074 File Offset: 0x00106274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LCOAGNJBCKG)
			{
				num ^= this.LCOAGNJBCKG.GetHashCode();
			}
			if (this.GGFKEIJJLCE)
			{
				num ^= this.GGFKEIJJLCE.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.Step != HeartDialStepType.Missing)
			{
				num ^= this.Step.GetHashCode();
			}
			if (this.CurEmotionType != HeartDialEmotionType.Peace)
			{
				num ^= this.CurEmotionType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x00108124 File Offset: 0x00106324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x0010812C File Offset: 0x0010632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x00108138 File Offset: 0x00106338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LCOAGNJBCKG)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.LCOAGNJBCKG);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.Step != HeartDialStepType.Missing)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Step);
			}
			if (this.CurEmotionType != HeartDialEmotionType.Peace)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.CurEmotionType);
			}
			if (this.GGFKEIJJLCE)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.GGFKEIJJLCE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x001081E8 File Offset: 0x001063E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LCOAGNJBCKG)
			{
				num += 2;
			}
			if (this.GGFKEIJJLCE)
			{
				num += 2;
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.Step != HeartDialStepType.Missing)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Step);
			}
			if (this.CurEmotionType != HeartDialEmotionType.Peace)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurEmotionType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x00108270 File Offset: 0x00106470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartDialScriptInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LCOAGNJBCKG)
			{
				this.LCOAGNJBCKG = other.LCOAGNJBCKG;
			}
			if (other.GGFKEIJJLCE)
			{
				this.GGFKEIJJLCE = other.GGFKEIJJLCE;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.Step != HeartDialStepType.Missing)
			{
				this.Step = other.Step;
			}
			if (other.CurEmotionType != HeartDialEmotionType.Peace)
			{
				this.CurEmotionType = other.CurEmotionType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x001082FC File Offset: 0x001064FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x00108308 File Offset: 0x00106508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.LCOAGNJBCKG = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.ScriptId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Step = (HeartDialStepType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.CurEmotionType = (HeartDialEmotionType)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.GGFKEIJJLCE = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025EC RID: 9708
		private static readonly MessageParser<HeartDialScriptInfo> _parser = new MessageParser<HeartDialScriptInfo>(() => new HeartDialScriptInfo());

		// Token: 0x040025ED RID: 9709
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025EE RID: 9710
		public const int LCOAGNJBCKGFieldNumber = 4;

		// Token: 0x040025EF RID: 9711
		private bool lCOAGNJBCKG_;

		// Token: 0x040025F0 RID: 9712
		public const int GGFKEIJJLCEFieldNumber = 15;

		// Token: 0x040025F1 RID: 9713
		private bool gGFKEIJJLCE_;

		// Token: 0x040025F2 RID: 9714
		public const int ScriptIdFieldNumber = 7;

		// Token: 0x040025F3 RID: 9715
		private uint scriptId_;

		// Token: 0x040025F4 RID: 9716
		public const int StepFieldNumber = 10;

		// Token: 0x040025F5 RID: 9717
		private HeartDialStepType step_;

		// Token: 0x040025F6 RID: 9718
		public const int CurEmotionTypeFieldNumber = 14;

		// Token: 0x040025F7 RID: 9719
		private HeartDialEmotionType curEmotionType_;
	}
}
