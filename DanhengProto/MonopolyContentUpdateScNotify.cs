using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B23 RID: 2851
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyContentUpdateScNotify : IMessage<MonopolyContentUpdateScNotify>, IMessage, IEquatable<MonopolyContentUpdateScNotify>, IDeepCloneable<MonopolyContentUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x06007E30 RID: 32304 RVA: 0x0014DAC5 File Offset: 0x0014BCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyContentUpdateScNotify> Parser
		{
			get
			{
				return MonopolyContentUpdateScNotify._parser;
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x06007E31 RID: 32305 RVA: 0x0014DACC File Offset: 0x0014BCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyContentUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06007E32 RID: 32306 RVA: 0x0014DADE File Offset: 0x0014BCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyContentUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x0014DAE5 File Offset: 0x0014BCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyContentUpdateScNotify()
		{
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x0014DAED File Offset: 0x0014BCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyContentUpdateScNotify(MonopolyContentUpdateScNotify other) : this()
		{
			this.hAIDICOCIOL_ = ((other.hAIDICOCIOL_ != null) ? other.hAIDICOCIOL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x0014DB22 File Offset: 0x0014BD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyContentUpdateScNotify Clone()
		{
			return new MonopolyContentUpdateScNotify(this);
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06007E36 RID: 32310 RVA: 0x0014DB2A File Offset: 0x0014BD2A
		// (set) Token: 0x06007E37 RID: 32311 RVA: 0x0014DB32 File Offset: 0x0014BD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH HAIDICOCIOL
		{
			get
			{
				return this.hAIDICOCIOL_;
			}
			set
			{
				this.hAIDICOCIOL_ = value;
			}
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0014DB3B File Offset: 0x0014BD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyContentUpdateScNotify);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0014DB49 File Offset: 0x0014BD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyContentUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HAIDICOCIOL, other.HAIDICOCIOL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x0014DB7C File Offset: 0x0014BD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hAIDICOCIOL_ != null)
			{
				num ^= this.HAIDICOCIOL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x0014DBB8 File Offset: 0x0014BDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x0014DBC0 File Offset: 0x0014BDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x0014DBC9 File Offset: 0x0014BDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hAIDICOCIOL_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HAIDICOCIOL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x0014DBFC File Offset: 0x0014BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hAIDICOCIOL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HAIDICOCIOL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x0014DC3C File Offset: 0x0014BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyContentUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hAIDICOCIOL_ != null)
			{
				if (this.hAIDICOCIOL_ == null)
				{
					this.HAIDICOCIOL = new NFOGHDHIDNH();
				}
				this.HAIDICOCIOL.MergeFrom(other.HAIDICOCIOL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x0014DC90 File Offset: 0x0014BE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x0014DC9C File Offset: 0x0014BE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.hAIDICOCIOL_ == null)
					{
						this.HAIDICOCIOL = new NFOGHDHIDNH();
					}
					input.ReadMessage(this.HAIDICOCIOL);
				}
			}
		}

		// Token: 0x04003067 RID: 12391
		private static readonly MessageParser<MonopolyContentUpdateScNotify> _parser = new MessageParser<MonopolyContentUpdateScNotify>(() => new MonopolyContentUpdateScNotify());

		// Token: 0x04003068 RID: 12392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003069 RID: 12393
		public const int HAIDICOCIOLFieldNumber = 7;

		// Token: 0x0400306A RID: 12394
		private NFOGHDHIDNH hAIDICOCIOL_;
	}
}
