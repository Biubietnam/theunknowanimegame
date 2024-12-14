using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008ED RID: 2285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HIEBMNLCFBB : IMessage<HIEBMNLCFBB>, IMessage, IEquatable<HIEBMNLCFBB>, IDeepCloneable<HIEBMNLCFBB>, IBufferMessage
	{
		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x060065E9 RID: 26089 RVA: 0x001106DD File Offset: 0x0010E8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HIEBMNLCFBB> Parser
		{
			get
			{
				return HIEBMNLCFBB._parser;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x060065EA RID: 26090 RVA: 0x001106E4 File Offset: 0x0010E8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HIEBMNLCFBBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x001106F6 File Offset: 0x0010E8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HIEBMNLCFBB.Descriptor;
			}
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x001106FD File Offset: 0x0010E8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HIEBMNLCFBB()
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00110705 File Offset: 0x0010E905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HIEBMNLCFBB(HIEBMNLCFBB other) : this()
		{
			this.miracleInfo_ = ((other.miracleInfo_ != null) ? other.miracleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0011073A File Offset: 0x0010E93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HIEBMNLCFBB Clone()
		{
			return new HIEBMNLCFBB(this);
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x060065EF RID: 26095 RVA: 0x00110742 File Offset: 0x0010E942
		// (set) Token: 0x060065F0 RID: 26096 RVA: 0x0011074A File Offset: 0x0010E94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle MiracleInfo
		{
			get
			{
				return this.miracleInfo_;
			}
			set
			{
				this.miracleInfo_ = value;
			}
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00110753 File Offset: 0x0010E953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HIEBMNLCFBB);
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00110761 File Offset: 0x0010E961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HIEBMNLCFBB other)
		{
			return other != null && (other == this || (object.Equals(this.MiracleInfo, other.MiracleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00110794 File Offset: 0x0010E994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.miracleInfo_ != null)
			{
				num ^= this.MiracleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x001107D0 File Offset: 0x0010E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x001107D8 File Offset: 0x0010E9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x001107E1 File Offset: 0x0010E9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.miracleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x00110814 File Offset: 0x0010EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.miracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x00110854 File Offset: 0x0010EA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HIEBMNLCFBB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.miracleInfo_ != null)
			{
				if (this.miracleInfo_ == null)
				{
					this.MiracleInfo = new GameRogueMiracle();
				}
				this.MiracleInfo.MergeFrom(other.MiracleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x001108A8 File Offset: 0x0010EAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x001108B4 File Offset: 0x0010EAB4
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
					if (this.miracleInfo_ == null)
					{
						this.MiracleInfo = new GameRogueMiracle();
					}
					input.ReadMessage(this.MiracleInfo);
				}
			}
		}

		// Token: 0x04002730 RID: 10032
		private static readonly MessageParser<HIEBMNLCFBB> _parser = new MessageParser<HIEBMNLCFBB>(() => new HIEBMNLCFBB());

		// Token: 0x04002731 RID: 10033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002732 RID: 10034
		public const int MiracleInfoFieldNumber = 7;

		// Token: 0x04002733 RID: 10035
		private GameRogueMiracle miracleInfo_;
	}
}
