using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BC9 RID: 3017
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumRandomEventStartScNotify : IMessage<MuseumRandomEventStartScNotify>, IMessage, IEquatable<MuseumRandomEventStartScNotify>, IDeepCloneable<MuseumRandomEventStartScNotify>, IBufferMessage
	{
		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x00160AD9 File Offset: 0x0015ECD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumRandomEventStartScNotify> Parser
		{
			get
			{
				return MuseumRandomEventStartScNotify._parser;
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x06008592 RID: 34194 RVA: 0x00160AE0 File Offset: 0x0015ECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumRandomEventStartScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x06008593 RID: 34195 RVA: 0x00160AF2 File Offset: 0x0015ECF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumRandomEventStartScNotify.Descriptor;
			}
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x00160AF9 File Offset: 0x0015ECF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventStartScNotify()
		{
		}

		// Token: 0x06008595 RID: 34197 RVA: 0x00160B01 File Offset: 0x0015ED01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventStartScNotify(MuseumRandomEventStartScNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008596 RID: 34198 RVA: 0x00160B36 File Offset: 0x0015ED36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventStartScNotify Clone()
		{
			return new MuseumRandomEventStartScNotify(this);
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x00160B3E File Offset: 0x0015ED3E
		// (set) Token: 0x06008598 RID: 34200 RVA: 0x00160B46 File Offset: 0x0015ED46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPEMMBHKCFD Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06008599 RID: 34201 RVA: 0x00160B4F File Offset: 0x0015ED4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumRandomEventStartScNotify);
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x00160B5D File Offset: 0x0015ED5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumRandomEventStartScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x00160B90 File Offset: 0x0015ED90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x00160BCC File Offset: 0x0015EDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x00160BD4 File Offset: 0x0015EDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x00160BDD File Offset: 0x0015EDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x00160C10 File Offset: 0x0015EE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x00160C50 File Offset: 0x0015EE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumRandomEventStartScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new OPEMMBHKCFD();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x00160CA4 File Offset: 0x0015EEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x00160CB0 File Offset: 0x0015EEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new OPEMMBHKCFD();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x0400332A RID: 13098
		private static readonly MessageParser<MuseumRandomEventStartScNotify> _parser = new MessageParser<MuseumRandomEventStartScNotify>(() => new MuseumRandomEventStartScNotify());

		// Token: 0x0400332B RID: 13099
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400332C RID: 13100
		public const int InfoFieldNumber = 13;

		// Token: 0x0400332D RID: 13101
		private OPEMMBHKCFD info_;
	}
}
