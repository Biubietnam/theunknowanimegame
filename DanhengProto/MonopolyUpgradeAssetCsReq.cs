using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B87 RID: 2951
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyUpgradeAssetCsReq : IMessage<MonopolyUpgradeAssetCsReq>, IMessage, IEquatable<MonopolyUpgradeAssetCsReq>, IDeepCloneable<MonopolyUpgradeAssetCsReq>, IBufferMessage
	{
		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x0600829B RID: 33435 RVA: 0x00157F4C File Offset: 0x0015614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyUpgradeAssetCsReq> Parser
		{
			get
			{
				return MonopolyUpgradeAssetCsReq._parser;
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x00157F53 File Offset: 0x00156153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyUpgradeAssetCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600829D RID: 33437 RVA: 0x00157F65 File Offset: 0x00156165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyUpgradeAssetCsReq.Descriptor;
			}
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x00157F6C File Offset: 0x0015616C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyUpgradeAssetCsReq()
		{
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x00157F74 File Offset: 0x00156174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyUpgradeAssetCsReq(MonopolyUpgradeAssetCsReq other) : this()
		{
			this.cGAAJPDAFMG_ = other.cGAAJPDAFMG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x00157F99 File Offset: 0x00156199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyUpgradeAssetCsReq Clone()
		{
			return new MonopolyUpgradeAssetCsReq(this);
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x060082A1 RID: 33441 RVA: 0x00157FA1 File Offset: 0x001561A1
		// (set) Token: 0x060082A2 RID: 33442 RVA: 0x00157FA9 File Offset: 0x001561A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGAAJPDAFMG
		{
			get
			{
				return this.cGAAJPDAFMG_;
			}
			set
			{
				this.cGAAJPDAFMG_ = value;
			}
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x00157FB2 File Offset: 0x001561B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyUpgradeAssetCsReq);
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x00157FC0 File Offset: 0x001561C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyUpgradeAssetCsReq other)
		{
			return other != null && (other == this || (this.CGAAJPDAFMG == other.CGAAJPDAFMG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x00157FF0 File Offset: 0x001561F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CGAAJPDAFMG != 0U)
			{
				num ^= this.CGAAJPDAFMG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0015802F File Offset: 0x0015622F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x00158037 File Offset: 0x00156237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x00158040 File Offset: 0x00156240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CGAAJPDAFMG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CGAAJPDAFMG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x00158074 File Offset: 0x00156274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CGAAJPDAFMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGAAJPDAFMG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x001580B2 File Offset: 0x001562B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyUpgradeAssetCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CGAAJPDAFMG != 0U)
			{
				this.CGAAJPDAFMG = other.CGAAJPDAFMG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x001580E3 File Offset: 0x001562E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x001580EC File Offset: 0x001562EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CGAAJPDAFMG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040031CC RID: 12748
		private static readonly MessageParser<MonopolyUpgradeAssetCsReq> _parser = new MessageParser<MonopolyUpgradeAssetCsReq>(() => new MonopolyUpgradeAssetCsReq());

		// Token: 0x040031CD RID: 12749
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031CE RID: 12750
		public const int CGAAJPDAFMGFieldNumber = 2;

		// Token: 0x040031CF RID: 12751
		private uint cGAAJPDAFMG_;
	}
}
