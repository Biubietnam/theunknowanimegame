using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E9 RID: 1513
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GateServerScNotify : IMessage<GateServerScNotify>, IMessage, IEquatable<GateServerScNotify>, IDeepCloneable<GateServerScNotify>, IBufferMessage
	{
		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x000BABE0 File Offset: 0x000B8DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GateServerScNotify> Parser
		{
			get
			{
				return GateServerScNotify._parser;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x000BABE7 File Offset: 0x000B8DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GateServerScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x000BABF9 File Offset: 0x000B8DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GateServerScNotify.Descriptor;
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x000BAC00 File Offset: 0x000B8E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GateServerScNotify()
		{
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x000BAC13 File Offset: 0x000B8E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GateServerScNotify(GateServerScNotify other) : this()
		{
			this.dOIAFBAIEKH_ = other.dOIAFBAIEKH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x000BAC38 File Offset: 0x000B8E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GateServerScNotify Clone()
		{
			return new GateServerScNotify(this);
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x000BAC40 File Offset: 0x000B8E40
		// (set) Token: 0x060043F9 RID: 17401 RVA: 0x000BAC48 File Offset: 0x000B8E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DOIAFBAIEKH
		{
			get
			{
				return this.dOIAFBAIEKH_;
			}
			set
			{
				this.dOIAFBAIEKH_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x000BAC5B File Offset: 0x000B8E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GateServerScNotify);
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x000BAC69 File Offset: 0x000B8E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GateServerScNotify other)
		{
			return other != null && (other == this || (!(this.DOIAFBAIEKH != other.DOIAFBAIEKH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x000BAC9C File Offset: 0x000B8E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DOIAFBAIEKH.Length != 0)
			{
				num ^= this.DOIAFBAIEKH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x000BACDD File Offset: 0x000B8EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x000BACE5 File Offset: 0x000B8EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x000BACEE File Offset: 0x000B8EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DOIAFBAIEKH.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DOIAFBAIEKH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x000BAD28 File Offset: 0x000B8F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DOIAFBAIEKH.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DOIAFBAIEKH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x000BAD6B File Offset: 0x000B8F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GateServerScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DOIAFBAIEKH.Length != 0)
			{
				this.DOIAFBAIEKH = other.DOIAFBAIEKH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x000BADA1 File Offset: 0x000B8FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000BADAC File Offset: 0x000B8FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DOIAFBAIEKH = input.ReadString();
				}
			}
		}

		// Token: 0x04001B3E RID: 6974
		private static readonly MessageParser<GateServerScNotify> _parser = new MessageParser<GateServerScNotify>(() => new GateServerScNotify());

		// Token: 0x04001B3F RID: 6975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B40 RID: 6976
		public const int DOIAFBAIEKHFieldNumber = 3;

		// Token: 0x04001B41 RID: 6977
		private string dOIAFBAIEKH_ = "";
	}
}
