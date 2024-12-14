using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000475 RID: 1141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSwordTrainingExamScRsp : IMessage<EnterSwordTrainingExamScRsp>, IMessage, IEquatable<EnterSwordTrainingExamScRsp>, IDeepCloneable<EnterSwordTrainingExamScRsp>, IBufferMessage
	{
		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x060032D1 RID: 13009 RVA: 0x0008BCB3 File Offset: 0x00089EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSwordTrainingExamScRsp> Parser
		{
			get
			{
				return EnterSwordTrainingExamScRsp._parser;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x0008BCBA File Offset: 0x00089EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSwordTrainingExamScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x060032D3 RID: 13011 RVA: 0x0008BCCC File Offset: 0x00089ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSwordTrainingExamScRsp.Descriptor;
			}
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0008BCD3 File Offset: 0x00089ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSwordTrainingExamScRsp()
		{
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0008BCDC File Offset: 0x00089EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSwordTrainingExamScRsp(EnterSwordTrainingExamScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x0008BD28 File Offset: 0x00089F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSwordTrainingExamScRsp Clone()
		{
			return new EnterSwordTrainingExamScRsp(this);
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x0008BD30 File Offset: 0x00089F30
		// (set) Token: 0x060032D8 RID: 13016 RVA: 0x0008BD38 File Offset: 0x00089F38
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

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x0008BD41 File Offset: 0x00089F41
		// (set) Token: 0x060032DA RID: 13018 RVA: 0x0008BD49 File Offset: 0x00089F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x0008BD52 File Offset: 0x00089F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSwordTrainingExamScRsp);
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0008BD60 File Offset: 0x00089F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSwordTrainingExamScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x0008BDB0 File Offset: 0x00089FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0008BE05 File Offset: 0x0008A005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0008BE0D File Offset: 0x0008A00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x0008BE18 File Offset: 0x0008A018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x0008BE74 File Offset: 0x0008A074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x0008BECC File Offset: 0x0008A0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSwordTrainingExamScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x0008BF34 File Offset: 0x0008A134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x0008BF40 File Offset: 0x0008A140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x0400143B RID: 5179
		private static readonly MessageParser<EnterSwordTrainingExamScRsp> _parser = new MessageParser<EnterSwordTrainingExamScRsp>(() => new EnterSwordTrainingExamScRsp());

		// Token: 0x0400143C RID: 5180
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400143D RID: 5181
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400143E RID: 5182
		private uint retcode_;

		// Token: 0x0400143F RID: 5183
		public const int BattleInfoFieldNumber = 14;

		// Token: 0x04001440 RID: 5184
		private SceneBattleInfo battleInfo_;
	}
}
