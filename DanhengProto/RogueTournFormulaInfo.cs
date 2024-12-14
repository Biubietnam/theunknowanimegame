using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB9 RID: 4025
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournFormulaInfo : IMessage<RogueTournFormulaInfo>, IMessage, IEquatable<RogueTournFormulaInfo>, IDeepCloneable<RogueTournFormulaInfo>, IBufferMessage
	{
		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600B35B RID: 45915 RVA: 0x001E1D53 File Offset: 0x001DFF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournFormulaInfo> Parser
		{
			get
			{
				return RogueTournFormulaInfo._parser;
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600B35C RID: 45916 RVA: 0x001E1D5A File Offset: 0x001DFF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournFormulaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600B35D RID: 45917 RVA: 0x001E1D6C File Offset: 0x001DFF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournFormulaInfo.Descriptor;
			}
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x001E1D73 File Offset: 0x001DFF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaInfo()
		{
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x001E1D88 File Offset: 0x001DFF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaInfo(RogueTournFormulaInfo other) : this()
		{
			this.formulaTypeValue_ = ((other.formulaTypeValue_ != null) ? other.formulaTypeValue_.Clone() : null);
			this.gameFormulaInfo_ = other.gameFormulaInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x001E1DD9 File Offset: 0x001DFFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaInfo Clone()
		{
			return new RogueTournFormulaInfo(this);
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600B361 RID: 45921 RVA: 0x001E1DE1 File Offset: 0x001DFFE1
		// (set) Token: 0x0600B362 RID: 45922 RVA: 0x001E1DE9 File Offset: 0x001DFFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaTypeValue FormulaTypeValue
		{
			get
			{
				return this.formulaTypeValue_;
			}
			set
			{
				this.formulaTypeValue_ = value;
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600B363 RID: 45923 RVA: 0x001E1DF2 File Offset: 0x001DFFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormulaInfo> GameFormulaInfo
		{
			get
			{
				return this.gameFormulaInfo_;
			}
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x001E1DFA File Offset: 0x001DFFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournFormulaInfo);
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x001E1E08 File Offset: 0x001E0008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournFormulaInfo other)
		{
			return other != null && (other == this || (object.Equals(this.FormulaTypeValue, other.FormulaTypeValue) && this.gameFormulaInfo_.Equals(other.gameFormulaInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x001E1E5C File Offset: 0x001E005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.formulaTypeValue_ != null)
			{
				num ^= this.FormulaTypeValue.GetHashCode();
			}
			num ^= this.gameFormulaInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x001E1EA6 File Offset: 0x001E00A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B368 RID: 45928 RVA: 0x001E1EAE File Offset: 0x001E00AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B369 RID: 45929 RVA: 0x001E1EB8 File Offset: 0x001E00B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.formulaTypeValue_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FormulaTypeValue);
			}
			this.gameFormulaInfo_.WriteTo(ref output, RogueTournFormulaInfo._repeated_gameFormulaInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x001E1F08 File Offset: 0x001E0108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.formulaTypeValue_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FormulaTypeValue);
			}
			num += this.gameFormulaInfo_.CalculateSize(RogueTournFormulaInfo._repeated_gameFormulaInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x001E1F5C File Offset: 0x001E015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournFormulaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.formulaTypeValue_ != null)
			{
				if (this.formulaTypeValue_ == null)
				{
					this.FormulaTypeValue = new FormulaTypeValue();
				}
				this.FormulaTypeValue.MergeFrom(other.FormulaTypeValue);
			}
			this.gameFormulaInfo_.Add(other.gameFormulaInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x001E1FC1 File Offset: 0x001E01C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x001E1FCC File Offset: 0x001E01CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gameFormulaInfo_.AddEntriesFrom(ref input, RogueTournFormulaInfo._repeated_gameFormulaInfo_codec);
					}
				}
				else
				{
					if (this.formulaTypeValue_ == null)
					{
						this.FormulaTypeValue = new FormulaTypeValue();
					}
					input.ReadMessage(this.FormulaTypeValue);
				}
			}
		}

		// Token: 0x040048D2 RID: 18642
		private static readonly MessageParser<RogueTournFormulaInfo> _parser = new MessageParser<RogueTournFormulaInfo>(() => new RogueTournFormulaInfo());

		// Token: 0x040048D3 RID: 18643
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048D4 RID: 18644
		public const int FormulaTypeValueFieldNumber = 2;

		// Token: 0x040048D5 RID: 18645
		private FormulaTypeValue formulaTypeValue_;

		// Token: 0x040048D6 RID: 18646
		public const int GameFormulaInfoFieldNumber = 13;

		// Token: 0x040048D7 RID: 18647
		private static readonly FieldCodec<FormulaInfo> _repeated_gameFormulaInfo_codec = FieldCodec.ForMessage<FormulaInfo>(106U, FormulaInfo.Parser);

		// Token: 0x040048D8 RID: 18648
		private readonly RepeatedField<FormulaInfo> gameFormulaInfo_ = new RepeatedField<FormulaInfo>();
	}
}
