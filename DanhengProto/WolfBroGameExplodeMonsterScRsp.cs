using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001429 RID: 5161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameExplodeMonsterScRsp : IMessage<WolfBroGameExplodeMonsterScRsp>, IMessage, IEquatable<WolfBroGameExplodeMonsterScRsp>, IDeepCloneable<WolfBroGameExplodeMonsterScRsp>, IBufferMessage
	{
		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x0600E63F RID: 58943 RVA: 0x00263FC8 File Offset: 0x002621C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameExplodeMonsterScRsp> Parser
		{
			get
			{
				return WolfBroGameExplodeMonsterScRsp._parser;
			}
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x0600E640 RID: 58944 RVA: 0x00263FCF File Offset: 0x002621CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameExplodeMonsterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x0600E641 RID: 58945 RVA: 0x00263FE1 File Offset: 0x002621E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameExplodeMonsterScRsp.Descriptor;
			}
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x00263FE8 File Offset: 0x002621E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameExplodeMonsterScRsp()
		{
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x00263FF0 File Offset: 0x002621F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameExplodeMonsterScRsp(WolfBroGameExplodeMonsterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x00264015 File Offset: 0x00262215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameExplodeMonsterScRsp Clone()
		{
			return new WolfBroGameExplodeMonsterScRsp(this);
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x0600E645 RID: 58949 RVA: 0x0026401D File Offset: 0x0026221D
		// (set) Token: 0x0600E646 RID: 58950 RVA: 0x00264025 File Offset: 0x00262225
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

		// Token: 0x0600E647 RID: 58951 RVA: 0x0026402E File Offset: 0x0026222E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameExplodeMonsterScRsp);
		}

		// Token: 0x0600E648 RID: 58952 RVA: 0x0026403C File Offset: 0x0026223C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameExplodeMonsterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E649 RID: 58953 RVA: 0x0026406C File Offset: 0x0026226C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x002640AB File Offset: 0x002622AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E64B RID: 58955 RVA: 0x002640B3 File Offset: 0x002622B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E64C RID: 58956 RVA: 0x002640BC File Offset: 0x002622BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E64D RID: 58957 RVA: 0x002640F0 File Offset: 0x002622F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E64E RID: 58958 RVA: 0x0026412E File Offset: 0x0026232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameExplodeMonsterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E64F RID: 58959 RVA: 0x0026415F File Offset: 0x0026235F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E650 RID: 58960 RVA: 0x00264168 File Offset: 0x00262368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005B65 RID: 23397
		private static readonly MessageParser<WolfBroGameExplodeMonsterScRsp> _parser = new MessageParser<WolfBroGameExplodeMonsterScRsp>(() => new WolfBroGameExplodeMonsterScRsp());

		// Token: 0x04005B66 RID: 23398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B67 RID: 23399
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04005B68 RID: 23400
		private uint retcode_;
	}
}
