using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001439 RID: 5177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchEnhanceBuffFuncInfo : IMessage<WorkbenchEnhanceBuffFuncInfo>, IMessage, IEquatable<WorkbenchEnhanceBuffFuncInfo>, IDeepCloneable<WorkbenchEnhanceBuffFuncInfo>, IBufferMessage
	{
		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x00265D10 File Offset: 0x00263F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchEnhanceBuffFuncInfo> Parser
		{
			get
			{
				return WorkbenchEnhanceBuffFuncInfo._parser;
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x0600E6F6 RID: 59126 RVA: 0x00265D17 File Offset: 0x00263F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchEnhanceBuffFuncInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x00265D29 File Offset: 0x00263F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchEnhanceBuffFuncInfo.Descriptor;
			}
		}

		// Token: 0x0600E6F8 RID: 59128 RVA: 0x00265D30 File Offset: 0x00263F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffFuncInfo()
		{
		}

		// Token: 0x0600E6F9 RID: 59129 RVA: 0x00265D44 File Offset: 0x00263F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffFuncInfo(WorkbenchEnhanceBuffFuncInfo other) : this()
		{
			this.buffEnhanceCostMap_ = other.buffEnhanceCostMap_.Clone();
			this.curNum_ = other.curNum_;
			this.maxNum_ = other.maxNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6FA RID: 59130 RVA: 0x00265D91 File Offset: 0x00263F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffFuncInfo Clone()
		{
			return new WorkbenchEnhanceBuffFuncInfo(this);
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x00265D99 File Offset: 0x00263F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> BuffEnhanceCostMap
		{
			get
			{
				return this.buffEnhanceCostMap_;
			}
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x0600E6FC RID: 59132 RVA: 0x00265DA1 File Offset: 0x00263FA1
		// (set) Token: 0x0600E6FD RID: 59133 RVA: 0x00265DA9 File Offset: 0x00263FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurNum
		{
			get
			{
				return this.curNum_;
			}
			set
			{
				this.curNum_ = value;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x00265DB2 File Offset: 0x00263FB2
		// (set) Token: 0x0600E6FF RID: 59135 RVA: 0x00265DBA File Offset: 0x00263FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxNum
		{
			get
			{
				return this.maxNum_;
			}
			set
			{
				this.maxNum_ = value;
			}
		}

		// Token: 0x0600E700 RID: 59136 RVA: 0x00265DC3 File Offset: 0x00263FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchEnhanceBuffFuncInfo);
		}

		// Token: 0x0600E701 RID: 59137 RVA: 0x00265DD4 File Offset: 0x00263FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchEnhanceBuffFuncInfo other)
		{
			return other != null && (other == this || (this.BuffEnhanceCostMap.Equals(other.BuffEnhanceCostMap) && this.CurNum == other.CurNum && this.MaxNum == other.MaxNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E702 RID: 59138 RVA: 0x00265E34 File Offset: 0x00264034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.BuffEnhanceCostMap.GetHashCode();
			if (this.CurNum != 0U)
			{
				num ^= this.CurNum.GetHashCode();
			}
			if (this.MaxNum != 0U)
			{
				num ^= this.MaxNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E703 RID: 59139 RVA: 0x00265E9A File Offset: 0x0026409A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x00265EA2 File Offset: 0x002640A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x00265EAC File Offset: 0x002640AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxNum != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxNum);
			}
			this.buffEnhanceCostMap_.WriteTo(ref output, WorkbenchEnhanceBuffFuncInfo._map_buffEnhanceCostMap_codec);
			if (this.CurNum != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CurNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x00265F18 File Offset: 0x00264118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffEnhanceCostMap_.CalculateSize(WorkbenchEnhanceBuffFuncInfo._map_buffEnhanceCostMap_codec);
			if (this.CurNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurNum);
			}
			if (this.MaxNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E707 RID: 59143 RVA: 0x00265F84 File Offset: 0x00264184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchEnhanceBuffFuncInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.buffEnhanceCostMap_.MergeFrom(other.buffEnhanceCostMap_);
			if (other.CurNum != 0U)
			{
				this.CurNum = other.CurNum;
			}
			if (other.MaxNum != 0U)
			{
				this.MaxNum = other.MaxNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E708 RID: 59144 RVA: 0x00265FE5 File Offset: 0x002641E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E709 RID: 59145 RVA: 0x00265FF0 File Offset: 0x002641F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 34U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurNum = input.ReadUInt32();
						}
					}
					else
					{
						this.buffEnhanceCostMap_.AddEntriesFrom(ref input, WorkbenchEnhanceBuffFuncInfo._map_buffEnhanceCostMap_codec);
					}
				}
				else
				{
					this.MaxNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005BA3 RID: 23459
		private static readonly MessageParser<WorkbenchEnhanceBuffFuncInfo> _parser = new MessageParser<WorkbenchEnhanceBuffFuncInfo>(() => new WorkbenchEnhanceBuffFuncInfo());

		// Token: 0x04005BA4 RID: 23460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BA5 RID: 23461
		public const int BuffEnhanceCostMapFieldNumber = 4;

		// Token: 0x04005BA6 RID: 23462
		private static readonly MapField<uint, uint>.Codec _map_buffEnhanceCostMap_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 34U);

		// Token: 0x04005BA7 RID: 23463
		private readonly MapField<uint, uint> buffEnhanceCostMap_ = new MapField<uint, uint>();

		// Token: 0x04005BA8 RID: 23464
		public const int CurNumFieldNumber = 11;

		// Token: 0x04005BA9 RID: 23465
		private uint curNum_;

		// Token: 0x04005BAA RID: 23466
		public const int MaxNumFieldNumber = 2;

		// Token: 0x04005BAB RID: 23467
		private uint maxNum_;
	}
}
