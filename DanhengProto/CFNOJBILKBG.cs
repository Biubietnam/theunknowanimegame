using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000187 RID: 391
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CFNOJBILKBG : IMessage<CFNOJBILKBG>, IMessage, IEquatable<CFNOJBILKBG>, IDeepCloneable<CFNOJBILKBG>, IBufferMessage
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00032555 File Offset: 0x00030755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CFNOJBILKBG> Parser
		{
			get
			{
				return CFNOJBILKBG._parser;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0003255C File Offset: 0x0003075C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CFNOJBILKBGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0003256E File Offset: 0x0003076E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CFNOJBILKBG.Descriptor;
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00032575 File Offset: 0x00030775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFNOJBILKBG()
		{
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0003257D File Offset: 0x0003077D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFNOJBILKBG(CFNOJBILKBG other) : this()
		{
			this.rogueFormulaSelectInfo_ = ((other.rogueFormulaSelectInfo_ != null) ? other.rogueFormulaSelectInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000325B2 File Offset: 0x000307B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFNOJBILKBG Clone()
		{
			return new CFNOJBILKBG(this);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x000325BA File Offset: 0x000307BA
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x000325C2 File Offset: 0x000307C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFormulaSelectInfo RogueFormulaSelectInfo
		{
			get
			{
				return this.rogueFormulaSelectInfo_;
			}
			set
			{
				this.rogueFormulaSelectInfo_ = value;
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000325CB File Offset: 0x000307CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CFNOJBILKBG);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000325D9 File Offset: 0x000307D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CFNOJBILKBG other)
		{
			return other != null && (other == this || (object.Equals(this.RogueFormulaSelectInfo, other.RogueFormulaSelectInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0003260C File Offset: 0x0003080C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueFormulaSelectInfo_ != null)
			{
				num ^= this.RogueFormulaSelectInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00032648 File Offset: 0x00030848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00032650 File Offset: 0x00030850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00032659 File Offset: 0x00030859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueFormulaSelectInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueFormulaSelectInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0003268C File Offset: 0x0003088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueFormulaSelectInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFormulaSelectInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000326CC File Offset: 0x000308CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CFNOJBILKBG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueFormulaSelectInfo_ != null)
			{
				if (this.rogueFormulaSelectInfo_ == null)
				{
					this.RogueFormulaSelectInfo = new RogueFormulaSelectInfo();
				}
				this.RogueFormulaSelectInfo.MergeFrom(other.RogueFormulaSelectInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00032720 File Offset: 0x00030920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0003272C File Offset: 0x0003092C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueFormulaSelectInfo_ == null)
					{
						this.RogueFormulaSelectInfo = new RogueFormulaSelectInfo();
					}
					input.ReadMessage(this.RogueFormulaSelectInfo);
				}
			}
		}

		// Token: 0x04000759 RID: 1881
		private static readonly MessageParser<CFNOJBILKBG> _parser = new MessageParser<CFNOJBILKBG>(() => new CFNOJBILKBG());

		// Token: 0x0400075A RID: 1882
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400075B RID: 1883
		public const int RogueFormulaSelectInfoFieldNumber = 2;

		// Token: 0x0400075C RID: 1884
		private RogueFormulaSelectInfo rogueFormulaSelectInfo_;
	}
}
