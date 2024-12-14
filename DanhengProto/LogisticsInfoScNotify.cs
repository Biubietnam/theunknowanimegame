using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A69 RID: 2665
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsInfoScNotify : IMessage<LogisticsInfoScNotify>, IMessage, IEquatable<LogisticsInfoScNotify>, IDeepCloneable<LogisticsInfoScNotify>, IBufferMessage
	{
		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x0013988D File Offset: 0x00137A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsInfoScNotify> Parser
		{
			get
			{
				return LogisticsInfoScNotify._parser;
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06007626 RID: 30246 RVA: 0x00139894 File Offset: 0x00137A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06007627 RID: 30247 RVA: 0x001398A6 File Offset: 0x00137AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x001398AD File Offset: 0x00137AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsInfoScNotify()
		{
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x001398B5 File Offset: 0x00137AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsInfoScNotify(LogisticsInfoScNotify other) : this()
		{
			this.jAAMCLIBAIO_ = ((other.jAAMCLIBAIO_ != null) ? other.jAAMCLIBAIO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x001398EA File Offset: 0x00137AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsInfoScNotify Clone()
		{
			return new LogisticsInfoScNotify(this);
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600762B RID: 30251 RVA: 0x001398F2 File Offset: 0x00137AF2
		// (set) Token: 0x0600762C RID: 30252 RVA: 0x001398FA File Offset: 0x00137AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AEBKGEAGJCJ JAAMCLIBAIO
		{
			get
			{
				return this.jAAMCLIBAIO_;
			}
			set
			{
				this.jAAMCLIBAIO_ = value;
			}
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00139903 File Offset: 0x00137B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsInfoScNotify);
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00139911 File Offset: 0x00137B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.JAAMCLIBAIO, other.JAAMCLIBAIO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00139944 File Offset: 0x00137B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jAAMCLIBAIO_ != null)
			{
				num ^= this.JAAMCLIBAIO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00139980 File Offset: 0x00137B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00139988 File Offset: 0x00137B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00139991 File Offset: 0x00137B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jAAMCLIBAIO_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.JAAMCLIBAIO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x001399C4 File Offset: 0x00137BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jAAMCLIBAIO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JAAMCLIBAIO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00139A04 File Offset: 0x00137C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jAAMCLIBAIO_ != null)
			{
				if (this.jAAMCLIBAIO_ == null)
				{
					this.JAAMCLIBAIO = new AEBKGEAGJCJ();
				}
				this.JAAMCLIBAIO.MergeFrom(other.JAAMCLIBAIO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00139A58 File Offset: 0x00137C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00139A64 File Offset: 0x00137C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.jAAMCLIBAIO_ == null)
					{
						this.JAAMCLIBAIO = new AEBKGEAGJCJ();
					}
					input.ReadMessage(this.JAAMCLIBAIO);
				}
			}
		}

		// Token: 0x04002D67 RID: 11623
		private static readonly MessageParser<LogisticsInfoScNotify> _parser = new MessageParser<LogisticsInfoScNotify>(() => new LogisticsInfoScNotify());

		// Token: 0x04002D68 RID: 11624
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D69 RID: 11625
		public const int JAAMCLIBAIOFieldNumber = 15;

		// Token: 0x04002D6A RID: 11626
		private AEBKGEAGJCJ jAAMCLIBAIO_;
	}
}
