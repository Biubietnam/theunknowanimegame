using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E2F RID: 3631
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonActionResult : IMessage<RogueCommonActionResult>, IMessage, IEquatable<RogueCommonActionResult>, IDeepCloneable<RogueCommonActionResult>, IBufferMessage
	{
		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0600A1EC RID: 41452 RVA: 0x001B1A4B File Offset: 0x001AFC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonActionResult> Parser
		{
			get
			{
				return RogueCommonActionResult._parser;
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600A1ED RID: 41453 RVA: 0x001B1A52 File Offset: 0x001AFC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonActionResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x001B1A64 File Offset: 0x001AFC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonActionResult.Descriptor;
			}
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x001B1A6B File Offset: 0x001AFC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResult()
		{
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x001B1A74 File Offset: 0x001AFC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResult(RogueCommonActionResult other) : this()
		{
			this.source_ = other.source_;
			this.rogueAction_ = ((other.rogueAction_ != null) ? other.rogueAction_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x001B1AC0 File Offset: 0x001AFCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResult Clone()
		{
			return new RogueCommonActionResult(this);
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600A1F2 RID: 41458 RVA: 0x001B1AC8 File Offset: 0x001AFCC8
		// (set) Token: 0x0600A1F3 RID: 41459 RVA: 0x001B1AD0 File Offset: 0x001AFCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultSourceType Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0600A1F4 RID: 41460 RVA: 0x001B1AD9 File Offset: 0x001AFCD9
		// (set) Token: 0x0600A1F5 RID: 41461 RVA: 0x001B1AE1 File Offset: 0x001AFCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonActionResultData RogueAction
		{
			get
			{
				return this.rogueAction_;
			}
			set
			{
				this.rogueAction_ = value;
			}
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x001B1AEA File Offset: 0x001AFCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonActionResult);
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x001B1AF8 File Offset: 0x001AFCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonActionResult other)
		{
			return other != null && (other == this || (this.Source == other.Source && object.Equals(this.RogueAction, other.RogueAction) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x001B1B48 File Offset: 0x001AFD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Source != RogueCommonActionResultSourceType.None)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.rogueAction_ != null)
			{
				num ^= this.RogueAction.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x001B1BA3 File Offset: 0x001AFDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x001B1BAB File Offset: 0x001AFDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x001B1BB4 File Offset: 0x001AFDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueAction_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueAction);
			}
			if (this.Source != RogueCommonActionResultSourceType.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Source);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x001B1C10 File Offset: 0x001AFE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Source != RogueCommonActionResultSourceType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			if (this.rogueAction_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAction);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x001B1C68 File Offset: 0x001AFE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonActionResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Source != RogueCommonActionResultSourceType.None)
			{
				this.Source = other.Source;
			}
			if (other.rogueAction_ != null)
			{
				if (this.rogueAction_ == null)
				{
					this.RogueAction = new RogueCommonActionResultData();
				}
				this.RogueAction.MergeFrom(other.RogueAction);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x001B1CD0 File Offset: 0x001AFED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x001B1CDC File Offset: 0x001AFEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Source = (RogueCommonActionResultSourceType)input.ReadEnum();
					}
				}
				else
				{
					if (this.rogueAction_ == null)
					{
						this.RogueAction = new RogueCommonActionResultData();
					}
					input.ReadMessage(this.RogueAction);
				}
			}
		}

		// Token: 0x04004234 RID: 16948
		private static readonly MessageParser<RogueCommonActionResult> _parser = new MessageParser<RogueCommonActionResult>(() => new RogueCommonActionResult());

		// Token: 0x04004235 RID: 16949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004236 RID: 16950
		public const int SourceFieldNumber = 9;

		// Token: 0x04004237 RID: 16951
		private RogueCommonActionResultSourceType source_;

		// Token: 0x04004238 RID: 16952
		public const int RogueActionFieldNumber = 1;

		// Token: 0x04004239 RID: 16953
		private RogueCommonActionResultData rogueAction_;
	}
}
