using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A09 RID: 2569
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LFCKPPDLIJI : IMessage<LFCKPPDLIJI>, IMessage, IEquatable<LFCKPPDLIJI>, IDeepCloneable<LFCKPPDLIJI>, IBufferMessage
	{
		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x0012F3F0 File Offset: 0x0012D5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LFCKPPDLIJI> Parser
		{
			get
			{
				return LFCKPPDLIJI._parser;
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06007202 RID: 29186 RVA: 0x0012F3F7 File Offset: 0x0012D5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LFCKPPDLIJIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x0012F409 File Offset: 0x0012D609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LFCKPPDLIJI.Descriptor;
			}
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x0012F410 File Offset: 0x0012D610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFCKPPDLIJI()
		{
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x0012F418 File Offset: 0x0012D618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFCKPPDLIJI(LFCKPPDLIJI other) : this()
		{
			this.dAHIIJFDECO_ = ((other.dAHIIJFDECO_ != null) ? other.dAHIIJFDECO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x0012F44D File Offset: 0x0012D64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFCKPPDLIJI Clone()
		{
			return new LFCKPPDLIJI(this);
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x0012F455 File Offset: 0x0012D655
		// (set) Token: 0x06007208 RID: 29192 RVA: 0x0012F45D File Offset: 0x0012D65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEMCBINHGOA DAHIIJFDECO
		{
			get
			{
				return this.dAHIIJFDECO_;
			}
			set
			{
				this.dAHIIJFDECO_ = value;
			}
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x0012F466 File Offset: 0x0012D666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LFCKPPDLIJI);
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x0012F474 File Offset: 0x0012D674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LFCKPPDLIJI other)
		{
			return other != null && (other == this || (object.Equals(this.DAHIIJFDECO, other.DAHIIJFDECO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x0012F4A8 File Offset: 0x0012D6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dAHIIJFDECO_ != null)
			{
				num ^= this.DAHIIJFDECO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x0012F4EC File Offset: 0x0012D6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x0012F4F5 File Offset: 0x0012D6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dAHIIJFDECO_ != null)
			{
				output.WriteRawTag(170, 6);
				output.WriteMessage(this.DAHIIJFDECO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x0012F52C File Offset: 0x0012D72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dAHIIJFDECO_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DAHIIJFDECO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x0012F56C File Offset: 0x0012D76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LFCKPPDLIJI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dAHIIJFDECO_ != null)
			{
				if (this.dAHIIJFDECO_ == null)
				{
					this.DAHIIJFDECO = new OEMCBINHGOA();
				}
				this.DAHIIJFDECO.MergeFrom(other.DAHIIJFDECO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x0012F5C0 File Offset: 0x0012D7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x0012F5CC File Offset: 0x0012D7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 810U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.dAHIIJFDECO_ == null)
					{
						this.DAHIIJFDECO = new OEMCBINHGOA();
					}
					input.ReadMessage(this.DAHIIJFDECO);
				}
			}
		}

		// Token: 0x04002BCE RID: 11214
		private static readonly MessageParser<LFCKPPDLIJI> _parser = new MessageParser<LFCKPPDLIJI>(() => new LFCKPPDLIJI());

		// Token: 0x04002BCF RID: 11215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BD0 RID: 11216
		public const int DAHIIJFDECOFieldNumber = 101;

		// Token: 0x04002BD1 RID: 11217
		private OEMCBINHGOA dAHIIJFDECO_;
	}
}
